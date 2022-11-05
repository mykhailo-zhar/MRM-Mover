using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MRM_Class_Lib.Parser;

namespace MRM_Class_Lib
{
    //Геометрия
    public class Geometry_Processor
    {
        public Geometry_Processor(int Period = 100)
        {
            Thread thread = new Thread(() =>
            {
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    if (MRM_Parallel_Data.Failure) continue;

                    //TODO: Событие на сигнал остановки/продолжения
                    //TODO: Событие на сигнал об окончании 
                    MRM_Parallel_Data.Instruction.ProcessStep();
                    //TODO: передать управление ТЕХ процессу для движения

                    Thread.Sleep(Period);
                }
            });
            thread.Start();
        }


    }
}
