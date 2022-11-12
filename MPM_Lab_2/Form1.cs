using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRM_Class_Lib;
using MRM_Class_Lib.Parser;
using WMPLib;

namespace MPM_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Waiting();
            Clock.Start();
        }

        private MRM_Instruction_Executer Program_Instruction = new MRM_Instruction_Executer();
        private MRM_Manual_Executer Manual_Instruction = new MRM_Manual_Executer();

        bool ProgramOperatingMode => ProgramRB.Checked;

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            var instruction = MRM_Instruction.ProcessString(Command.Text);

            if (instruction.Error)
            {
                Bad();
            }
            else
            {
                Good();
                Program_Instruction.SetInstruction(instruction);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Waiting();
            Program_Instruction.DeleteInstruction();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var Dialog = new SaveFileDialog();
            Dialog.InitialDirectory = Directory.GetCurrentDirectory();
            Dialog.Filter = "Text Files | *.txt";
            Dialog.DefaultExt = "txt";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                using (var Stream = new StreamWriter(Dialog.FileName))
                {

                    Stream.WriteLine(Program_Instruction.ToPrint());
                    //else
                    //    Stream.WriteLine(Manual_Instruction.ToPrint());
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = Directory.GetCurrentDirectory();
            Dialog.Filter = "Text Files | *.txt";
            Dialog.DefaultExt = "txt";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                using (var Stream = new StreamReader(Dialog.FileName))
                {
                    Command.Text = Stream.ReadToEnd();
                    IdentifyButton_Click(sender, e);
                }
            }
        }
        bool OnlyOneFailure = false;
        private void Clock_Tick(object sender, EventArgs e)
        {
            if (MRM_Parallel_Data.Instruction != null &&
                MRM_Parallel_Data.Instruction.Completed &&
                StopButton.Enabled
                ) { StopButton_Click(sender, e); }

            if(MRM_Parallel_Data.Failure && !OnlyOneFailure)
            {
                OnlyOneFailure = true;
                //WindowsMediaPlayer player = new WindowsMediaPlayer();
                //player.URL = "Siren.mp3";
                //player.controls.play();
                MessageBox.Show("Движки в огне. ПОЛУНДРА! ЫЧА В ОГНЕ!", "АВАРИЯ", buttons: MessageBoxButtons.OK);

               
                MRM_Parallel_Data.TECH_CONS_ControlEvent.Set();
                StopButton_Click(sender, e);
                ManualRB.Enabled = ProgramRB.Enabled = false;
                StartButton.Enabled = false;
                StopButton.Enabled = false;
                
                SaveButton.Enabled = false;
                IdentifyButton.Enabled = false;
                LoadButton.Enabled = false;
                EditButton.Enabled = false;
            }

            //MRM.MRMCHPU();

            double
                  X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress) / 1000.0,
                  Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1) / 1000.0,
                  C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2) / 1000.0,
                  U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3) / 1000.0,
                  U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4) / 1000.0;

            bool Grep = MRM_IO.PortIn(MRM_IO.GrepAdress) == 1;

            ShowX.Text = $"{X,5:F2}";
            ShowY.Text = $"{Y,5:F2}";
            ShowZx.Text = $"{C,5:F2}";
            ShowU1.Text = $"{U1,5:F2}";
            ShowU2.Text = $"{U2,5:F2}";
            ShowGrep.BackColor = Grep ? Color.ForestGreen : Color.IndianRed;

            Manual_Instruction.X = Convert.ToDouble(UI_X.Value);
            Manual_Instruction.Y = Convert.ToDouble(UI_Y.Value);
            Manual_Instruction.Uz = Convert.ToDouble(UI_Uz.Value);
            Manual_Instruction.U1 = Convert.ToDouble(UI_U1.Value);
            Manual_Instruction.U2 = Convert.ToDouble(UI_U2.Value);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            MRM_IO.IOClear();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //После старта можно активировать кнопку Stop. Rb, Edit, Load, Start  выключаются.
            StartStop();
            if (ProgramOperatingMode)
            {
                if (Program_Instruction.Completed) { Program_Instruction.ResetInstruction(); }
                MRM_Parallel_Data.Instruction = Program_Instruction;
               
            }
            else
            {
                MRM_Parallel_Data.Instruction = Manual_Instruction;
            }
            MRM_Parallel_Data.CONS_GEOM_ControlEvent.Set();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MRM_Parallel_Data.TECH_CONS_ControlEvent.WaitOne();
            //После стопа активировать кнопки Rb, Edit, Load, Start. Деактивировать кнопку Stop
            StartStop(false);
            MRM_Parallel_Data.CONS_GEOM_ControlEvent.Reset();
        }

        private void Grep_Click(object sender, EventArgs e)
        {
            Manual_Instruction.Active_Grep = !Manual_Instruction.Active_Grep;
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            RB_Buttons();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MRM_IO.IOClose();
            MRM_Parallel_Data.Abort();
            MRM.Working = false;
        }
    }
}
