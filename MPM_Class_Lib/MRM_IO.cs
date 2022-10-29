using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace MPM_Class_Lib
{
    public class MRM_IO
    {
        [DllImport("MRM_IO.dll")]
        public static extern void IOOpen(short BaseAdr);
        [DllImport("MRM_IO.dll")]
        public static extern void IOClose();
        [DllImport("MRM_IO.dll")]
        public static extern void PortOut(short PortNo, short Value);
        [DllImport("MRM_IO.dll")]
        public static extern short PortIn(short PortNo);
    }
}
