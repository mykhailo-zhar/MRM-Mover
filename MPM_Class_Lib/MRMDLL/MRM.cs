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


        public static bool Working = true;

        public void MRMCHPU()
        {
            double
                       X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress) / 1000.0,
                       Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1) / 1000.0,
                       C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2) / 10.0,
                       U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3) / 10.0,
                       U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4) / 10.0;

            MRMSetAll(C, U1, U2, Y, X);
        }

        public static void Init_Connection()
        {
            new Thread(() => {
                while (Working)
                {
                    double
                         X = (short)MRM_IO.PortIn(MRM_IO.DOSAdress) / 1000.0,
                         Y = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 1) / 1000.0,
                         C = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 2) / 1000.0,
                         U1 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 3) / 1000.0,
                         U2 = (short)MRM_IO.PortIn(MRM_IO.DOSAdress + 4) / 1000.0;

                    MRMSetM_OFF();
                    MRMSetAll(C, U1, U2, Y, X);
                    MRMSetM_ON();
                }
            }).Start();
        }
    }
}
