using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MRM_Class_Lib.Parser;

namespace MRM_Class_Lib
{
    public static class MRM_Parallel_Data
    {
        public static bool Active_Grep { get; set; }

        public static double X { get; set; }
        public static double Y { get; set; }
        public static double Uz { get; set; }
        public static double U1 { get; set; }
        public static double U2 { get; set; }
        public static bool Failure { get; set; }

        public static MRM_Instruction_Executer Instruction { get; set; }

        public static ManualResetEvent GeometryControlEvent;

        public static bool ProgramWorking = true;
    }
}
