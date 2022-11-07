using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM_Class_Lib.Parser
{
    public class MRM_Manual_Executer : IInstructionExecuter
    {
        double Modifier = 100.0;

        private double x;
        public double X { get => x * Modifier; set => x = value; }

        private double y;
        public double Y { get => y * Modifier; set => y = value; }

        private double uz;
        public double Uz { get => uz * Modifier; set => uz = value; }

        private double u1;
        public double U1 { get => u1 * Modifier; set => u1 = value; }

        private double u2;
        public double U2 { get => u2 * Modifier; set => u2 = value; }

        public bool Active_Grep { get; set; }

        public bool Completed => false;

        public void ProcessStep()
        {

        }
    }
}
