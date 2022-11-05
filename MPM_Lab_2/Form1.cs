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

        private MRM_Instruction Program_Instruction;
        private MRM_Instruction Manual_Instruction;

        bool ProgramOperatingMode => ProgramRB.Checked;

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            var instructions = MRM_Instruction.ProcessString(Command.Text);

            if (instructions.Error)
            {
                Bad();
            }
            else
            {
                Good();
                Program_Instruction = instructions;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Waiting();
            Program_Instruction = null;
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
                    if(ProgramOperatingMode)
                         Stream.WriteLine(Program_Instruction.ToPrint());
                    else
                        Stream.WriteLine(Manual_Instruction.ToPrint());
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

        private void Clock_Tick(object sender, EventArgs e)
        {
            double
                  X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress) / 1000.0,
                  Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1) / 1000.0,
                  C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2) / 1000.0,
                  U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3) / 1000.0,
                  U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4) / 1000.0;

            ShowX.Text = $"{X,5:F2}";
            ShowY.Text = $"{Y,5:F2}";
            ShowZx.Text = $"{C,5:F2}";
            ShowU1.Text = $"{U1,5:F2}";
            ShowU2.Text = $"{U2,5:F2}";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            MRM_IO.IOClear();
        }
    }
}
