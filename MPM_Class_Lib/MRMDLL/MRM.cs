using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Runtime.InteropServices;

namespace MRM_Class_Lib
{
    public class MRM
    {
        [DllImport("MRM.dll")]
        public static extern void MRMCreate();

        [DllImport("MRM.dll")]
        public static extern void MRMSetON();

        [DllImport("MRM.dll")]
        public static extern void MRMSetOFF();

        [DllImport("MRM.dll")]
        public static extern void MRMSetM_ON();

        [DllImport("MRM.dll")]
        public static extern void MRMSetM_OFF();

        [DllImport("MRM.dll")]
        public static extern int MRMBuzy();

        [DllImport("MRM.dll")]
        public static extern void MRMSetC(double c);

        [DllImport("MRM.dll")]
        public static extern void MRMSetU(double u1, double u2);

        [DllImport("MRM.dll")]
        public static extern void MRMSetXY(double x, double y);

        [DllImport("MRM.dll")]
        public static extern void MRMSetAll(double c, double u1, double u2, double x, double y);

        private static void MRM_Timing(object target)
        {

            short
                  X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress),
                  Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1),
                  C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2),
                  U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3),
                  U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4);

            MRMSetAll(C, U1, U2, X, Y);
        }

        private static Timer Timer;
        private static Thread Thread;
        public static void Init_Connection()
        {
            Thread = new Thread(() => Timer = new Timer(new TimerCallback(MRM_Timing), null, 0, 100));
            Thread.Start();

        }
        public static void Close_Connection()
        {
            Thread.Join();
            Timer.Dispose();
        }
    }
}
