using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using MRM_Class_Lib;

namespace MPM_Lab_2
{
    static class MRM_View_Program
    {
        static void MPM()
        {

            double Rotations = 1.0;
            double MM = 100.0;

            MRM_IO.IOOpen(MRM_IO.BaseAdress);
            MRM_IO.IOClear();
            MRM_Drive.PrivodInit(2, 1000);
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  MRM_IO.CAPAdress,
                  MRM_IO.DOSAdress,
                  Rotations,
                  MM
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 1),
                  (short)(MRM_IO.DOSAdress + 1),
                  Rotations,
                  MM
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 2),
                  (short)(MRM_IO.DOSAdress + 2),
                 Rotations,
                  MM
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 3),
                  (short)(MRM_IO.DOSAdress + 3),
                  Rotations,
                  MM
                );
            MRM_Drive.PrivodCreate(
                  MRM_IO.BaseAdress,
                  (short)(MRM_IO.CAPAdress + 4),
                  (short)(MRM_IO.DOSAdress + 4),
                  Rotations,
                  MM
                );


            //MRM.MRMCreate();
            //MRM.MRMSetON();
            //MRM.Init_Connection();
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
        [STAThread]
        static void Main()
        {
            MPM();

            App();
            MRM_Parallel_Data.Log("Main", true);
        }
    }
}
