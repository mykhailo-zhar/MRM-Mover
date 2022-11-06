using System;
using System.IO;
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
        public static bool Active_Grep => Instruction.Active_Grep; 
        public static double X => Instruction.X ?? 0;
        public static double Y => Instruction.Y ?? 0;
        public static double Uz => Instruction.Uz ?? 0;
        public static double U1 => Instruction.U1 ?? 0;
        public static double U2 => Instruction.U2 ?? 0;
        public static bool Failure { get; set; }

        static Geometry_Processor GP = new Geometry_Processor();
        static Technology_Processor TP = new Technology_Processor();

        public static MRM_Instruction_Executer Instruction { get; set; }

        public static ManualResetEvent CONS_GEOM_ControlEvent = new ManualResetEvent(false);
        public static AutoResetEvent GEOM_TECH_ControlEvent = new AutoResetEvent(false);
        public static AutoResetEvent TECH_GEOM_ControlEvent = new AutoResetEvent(true);
        public static AutoResetEvent TECH_CONS_ControlEvent = new AutoResetEvent(false);

        public static void Abort()
        {
            CONS_GEOM_ControlEvent.Set();
            //GEOM_TECH_ControlEvent.Set();
            MRM.Working = false;
            ProgramWorking = false;
            TP.Abort();
        }
        private static object locker = new object();
        public static void Log(string @class, bool mainthread = false, string Message = "did its job and sippuqued itself")
        {
            lock (locker)
            {
                using (var SW = new StreamWriter("log.txt", true))
                {
                    SW.WriteLine($"{@class}{(mainthread ? "(Mainthread)" : "")} {Thread.CurrentThread.ManagedThreadId} {Message}");
                }
            }
           
        }

        public static bool ProgramWorking = true;
    }
}
