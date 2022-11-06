using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace MRM_Class_Lib
{
    public class MRM_IO
    {
        public static short BaseAdress = 0x300;
        public static short GrepAdress = (short)(BaseAdress + 2);
        public static short CAPAdress => (short)(BaseAdress + 6);
        public static short DOSAdress => (short)(BaseAdress + 12);

        [DllImport("MRM_IO.dll")]
        public static extern void IOOpen(int BaseAdr);
        [DllImport("MRM_IO.dll")]
        public static extern void IOClose();
        [DllImport("MRM_IO.dll")]
        public static extern void PortOut(int PortNo, int Value);
        [DllImport("MRM_IO.dll")]
        public static extern int PortIn(int PortNo);

        public static void IOInit()
        {
            IOOpen(BaseAdress);
        }

        public static void IOClear()
        {
            for (int i = BaseAdress; i < BaseAdress + 100; i++)
            {
                PortOut(i, 0);
            }
        }
    }
}
