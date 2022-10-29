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
        }

        private IEnumerable<MRM_Command> Commands;

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            var commands =
                Command.Text.Split(
                new[] { ';', ' ', ',', '.' , '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries
                )
                .Select(p => MRM_Command.ProcessString(p))      
                ;

            if (commands.Any(p => p.Command == MRM_Command_Enum.Error) ||
                commands.Count() == 0
                )
            {
                Bad();
            }
            else { 
                Good();
                Commands = commands;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Waiting();
            Commands = null;
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
                    Commands.ToList().ForEach(c => Stream.WriteLine(c.ToPrint()));
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
    }
}
