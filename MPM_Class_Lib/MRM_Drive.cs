using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace MRM_Class_Lib
{
    public class MRM_Drive
    {
        [DllImport("MRMPrivod.dll")]
        public static extern void PrivodInit(short InitMode, short Period);
        [DllImport("MRMPrivod.dll")]
        public static extern void PrivodCreate(short BasePort,short CAPPort,short DOSPort, double V_Oborot,double Oborot_mm);

    }
}
