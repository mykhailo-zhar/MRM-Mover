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
        Thread Thread;
        public Geometry_Processor(int Period = 100)
        {
            Thread = new Thread(() =>
            {
                MRM_Parallel_Data.Log(GetType().Name, true, "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    if (MRM_Parallel_Data.Failure) continue;

                    //Событие на сигнал остановки/продолжения
                    MRM_Parallel_Data.CONS_GEOM_ControlEvent.WaitOne();
                    //Событие на сигнал об окончании 
                    MRM_Parallel_Data.TECH_GEOM_ControlEvent.WaitOne();

                    //Шаг прощёта геометрии
                    MRM_Parallel_Data.Instruction.ProcessStep();

                    //Передать управление ТЕХ процессу для движения
                    MRM_Parallel_Data.GEOM_TECH_ControlEvent.Set();

                    Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name, true);
            });
            Thread.Start();
        }

    }
}
