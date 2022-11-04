using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MRM_Class_Lib;

namespace MPM_Lab_2
{
    static class MRM_View_Program
    {
        static void MPM()
        {
            MRM.MRMCreate();
            MRM_IO.IOOpen(0x300);
            MRM_IO.IOClear();
            MRM_Drive.PrivodInit(2, 100);
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  MRM_IO.CAPAdress,
                  MRM_IO.DOSAdress,
                  10.0,
                  1.0
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 1),
                  (short)(MRM_IO.DOSAdress + 1),
                  10.0,
                  1.0
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 2),
                  (short)(MRM_IO.DOSAdress + 2),
                  10.0,
                  1.0
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 3),
                  (short)(MRM_IO.DOSAdress + 3),
                  10.0,
                  1.0
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 4),
                  (short)(MRM_IO.DOSAdress + 4),
                  10.0,
                  1.0
                );

            MRM.MRMSetON();
            MRM.Init_Connection();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void App()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Main()
        {
            MPM();
            App();
            MRM.Close_Connection();
            MRM_IO.IOClose();
        }
    }
}
