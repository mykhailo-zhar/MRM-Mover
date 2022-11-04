﻿using System;
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

        private MRM_Instruction Instruction;

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            var instructions = MRM_Instruction.ProcessString(Command.Text);

            if (instructions.Error)
            {
                Bad();
            }
            else { 
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

        private void button1_Click(object sender, EventArgs e)
        {
            MRM.MRMCreate();
            MRM.MRMSetON();
            MRM.MRMSetAll(0, 0, -30, 1, 1);
        }
    }
}
