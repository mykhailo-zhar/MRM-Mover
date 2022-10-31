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
        [DllImport("MRM_IO.dll")]
        public static extern void IOOpen(int BaseAdr);
        [DllImport("MRM_IO.dll")]
        public static extern void IOClose();
        [DllImport("MRM_IO.dll")]
        public static extern void PortOut(int PortNo, int Value);
        [DllImport("MRM_IO.dll")]
        public static extern int PortIn(int PortNo);
    }
}
