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

        private MRM_Instruction Instruction;

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
                Instruction = instructions;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Waiting();
            Instruction = null;
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
                    Stream.WriteLine(Instruction.ToPrint());
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
            short
                X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress),
                Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1),
                C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2),
                U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3),
                U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4);

            ShowX.Text = $"{X,5:F2}";
            ShowY.Text = $"{Y,5:F2}";
            ShowZx.Text = $"{C,5:F2}";
            ShowU1.Text = $"{U1,5:F2}";
            ShowU2.Text = $"{U2,5:F2}";
        }
    }
}
