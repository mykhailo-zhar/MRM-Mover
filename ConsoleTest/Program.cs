using System;
using System.Threading;
using MRM_Class_Lib;

using System.Runtime.InteropServices;

namespace ConsoleTest
{
    class Program
    {

        //Описание функций импортируемых из DLL        
        [DllImport("MRM.dll")]
        public static extern void MRMCreate();
        [DllImport("MRM.dll")]
        public static extern void MRMSetON();
        [DllImport("MRM.dll")]
        public static extern void MRMSetAll(double c, double u1, double u2, double x, double y);

        static void IO()
        {

            MRM_IO.IOOpen(0);
            Console.WriteLine($"{ MRM_IO.PortIn(0)}");
            MRM_IO.PortOut(0, 100);
            Console.WriteLine($"{ MRM_IO.PortIn(0)}");

            for (int i = 0; i < 100; i++)
            {
                MRM_IO.PortOut(i, 0);
            }

            MRM_IO.IOClose();

        }
        [STAThread]
        static void MRM_Create()
        {
            MRMCreate();
            MRMSetON();
            MRMSetAll(0, 0, -30, 1, 1);
            /*HWND S,S1;

               S = FindWindow(NULL,"CALC");
               S1= FindWindowEx(S, 0, 0, "EXIT");
               SendMessage(S1, BM_CLICK, 0, 0);
            */
            Console.ReadLine();
        }

        static void MovIng()
        {
            var to_move = new MRM_Command_Processor(1.0, 10.0, 90.0, 1.0);
            for (int i = 0; i < 1000; i++)
            {
                to_move.Move();
                Console.WriteLine($"DU: {to_move.Acceleration, 2:F2} Speed: {to_move.CurrentSpeed, 2:F2} Distance: {to_move.CurrentDistance, 2:F2}");
                if (to_move.Completed) break;
            }
        }
        [STAThread]
        static void Main(string[] args)
        {

            MovIng();
        }
    }
}
