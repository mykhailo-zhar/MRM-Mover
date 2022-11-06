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
                    MRM_Parallel_Data.CONS_GEOM_ControlEvent.WaitOne();
                    //TODO: Событие на сигнал об окончании 
                    MRM_Parallel_Data.TECH_GEOM_ControlEvent.WaitOne();
                    MRM_Parallel_Data.Instruction.ProcessStep();
                    //TODO: передать управление ТЕХ процессу для движения
                    MRM_Parallel_Data.GEOM_TECH_ControlEvent.Set();

                    Thread.Sleep(Period);
                }
            });
            thread.Start();
        }


    }
}
