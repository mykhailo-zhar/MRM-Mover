using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
