using System;
using MRM_Class_Lib;


namespace ConsoleTest
{
    class Program
    {
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
        static void Main(string[] args)
        {
            MRM.MRMCreate();
            MRM.MRMSetON();

            for (int i = 0; i < 1000; i++)
            {
                MRM.MRMSetXY(i % 4, i % 4 );
                Console.ReadLine();
            }

           
            
        }
    }
}
