using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM_Lab_2
{

    public partial class Form1 : Form
    {


        public void IdentifyChange(Color color, bool Enabled = true)
        {
            Info.BackColor = color;
            SaveButton.Enabled = Enabled;
            StartButton.Enabled = Enabled || !ProgramOperatingMode;
            Command.ReadOnly = Enabled;
            IdentifyButton.Enabled = !Enabled;
            StopButton.Enabled = false;
        }

        public void Good() => IdentifyChange(Color.ForestGreen, true);
        public void Bad() => IdentifyChange(Color.IndianRed, false);
        public void Waiting() => IdentifyChange(SystemColors.Control, false);

        public void StartStop(bool Start = true)
        {
            StopButton.Enabled = Start;
            StartButton.Enabled = !Start;

            ManualRB.Enabled = !Start;
            ProgramRB.Enabled = !Start;

            if (ProgramOperatingMode)
            {
                LoadButton.Enabled = !Start;
                EditButton.Enabled = !Start;
            }
        }
        public void RB_Buttons()
        {
            if (ProgramOperatingMode)
            {
                if (Info.BackColor == Color.ForestGreen)
                {
                    Good();
                }
                else if (Info.BackColor == Color.IndianRed)
                {
                    Bad();
                }
                else Waiting();
            }
            else
            {
                StartButton.Enabled = true;
            }
        }

    }
}
