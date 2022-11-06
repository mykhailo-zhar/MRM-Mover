using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRM_Class_Lib
{
    public class Technology_Processor
    {
        public Technology_Processor(int Period = 100)
        {
            var actions = new Action[]
               {
                    Write_X,
                    Write_Y,
                    Write_Uz,
                    Write_U1,
                    Write_U2
               };
            var threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                events[i] = new AutoResetEvent(false);
                threads[i] = new Thread(() => { while (MRM_Parallel_Data.ProgramWorking) { actions[i].Invoke(); Thread.Sleep(100); } });
                threads[i].Start();
            }

            new Thread(() =>
            {
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    //TODO: События на начало обработки
                    MRM_Parallel_Data.GEOM_TECH_ControlEvent.WaitOne();
                    if (MRM_Parallel_Data.Failure) continue;
                    TestFailure();

                    if (MRM_Parallel_Data.Failure) continue;
                    Write_Grep();

                    for (int i = 0; i < 5; i++)
                    {
                        events[i].Set();
                    }
                    MRM_Parallel_Data.TECH_GEOM_ControlEvent.Set();
                    Thread.Sleep(Period);
                }

            }).Start();
           
        }

        AutoResetEvent[] events = new AutoResetEvent[5];
        private void TestFailure()
        {
            MRM_Parallel_Data.Failure &= MRM_IO.PortIn(MRM_IO.DOSAdress + 0) == 1;
            MRM_Parallel_Data.Failure &= MRM_IO.PortIn(MRM_IO.DOSAdress + 1) == 1;
            MRM_Parallel_Data.Failure &= MRM_IO.PortIn(MRM_IO.DOSAdress + 2) == 1;
            MRM_Parallel_Data.Failure &= MRM_IO.PortIn(MRM_IO.DOSAdress + 3) == 1;
            MRM_Parallel_Data.Failure &= MRM_IO.PortIn(MRM_IO.DOSAdress + 4) == 1;
        }
        private void Write_Grep() => MRM_IO.PortOut(
            MRM_IO.GrepAdress,
            MRM_Parallel_Data.Active_Grep ? 1 : 0
            );
        private void Write_X()
        {
            events[0].WaitOne();
            MRM_IO.PortOut(
                MRM_IO.CAPAdress + 0,
                (int)MRM_Parallel_Data.X
            );
        }
        private void Write_Y()
        {
            events[1].WaitOne();
            MRM_IO.PortOut(
                MRM_IO.CAPAdress + 1,
                (int)MRM_Parallel_Data.Y
            );
        }
        private void Write_Uz()
        {
            events[2].WaitOne();
            MRM_IO.PortOut(
                MRM_IO.CAPAdress + 2,
                (int)MRM_Parallel_Data.Uz
            );
        }
        private void Write_U1()
        {
            events[3].WaitOne();
            MRM_IO.PortOut(
                MRM_IO.CAPAdress + 3,
                (int)MRM_Parallel_Data.U1
            );
        }
        private void Write_U2()
        {
            events[4].WaitOne();
            MRM_IO.PortOut(
                MRM_IO.CAPAdress + 4,
                (int)MRM_Parallel_Data.U2
            );
        }


    }
}
