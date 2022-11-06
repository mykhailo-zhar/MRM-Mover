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
            threads = new Thread[5];

           
            threads[0] = new Thread(() => {
                MRM_Parallel_Data.Log(GetType().Name, Message: "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    Write_X(); Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name);
            });
            threads[1] = new Thread(() => {
                MRM_Parallel_Data.Log(GetType().Name, Message: "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    Write_Y(); Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name);
            });
           threads[2] = new Thread(() => {
               MRM_Parallel_Data.Log(GetType().Name, Message: "Started");
               while (MRM_Parallel_Data.ProgramWorking)
                {
                    Write_Uz(); Thread.Sleep(Period);
                }
               MRM_Parallel_Data.Log(GetType().Name);
           });
            threads[3] = new Thread(() => {
                MRM_Parallel_Data.Log(GetType().Name, Message: "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    Write_U1(); Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name);
            });
            threads[4] = new Thread(() => {
                MRM_Parallel_Data.Log(GetType().Name, Message: "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    Write_U2(); Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name);
            });

            for (int i = 0; i < 5; i++)
            {
                events[i] = new AutoResetEvent(false);
                threads[i].Start();
            }

            MainThread = new Thread(() =>
            {
                MRM_Parallel_Data.Log(GetType().Name, true, "Started");
                while (MRM_Parallel_Data.ProgramWorking)
                {
                    //События на начало обработки
                    MRM_Parallel_Data.GEOM_TECH_ControlEvent.WaitOne();
                    if (MRM_Parallel_Data.Failure) continue;
                    TestFailure();

                    if (MRM_Parallel_Data.Failure) continue;
                    Write_Grep();

                    var x = MRM_Parallel_Data.X; if (x != 0) events[0].Set();
                    var y = MRM_Parallel_Data.Y; if (y != 0) events[1].Set();
                    var uz = MRM_Parallel_Data.Uz; if (uz != 0) events[2].Set();
                    var u1 = MRM_Parallel_Data.U1; if (u1 != 0) events[3].Set();
                    var u2 = MRM_Parallel_Data.U2; if (u2 != 0) events[4].Set();



                    MRM_Parallel_Data.TECH_GEOM_ControlEvent.Set();
                    MRM_Parallel_Data.TECH_CONS_ControlEvent.Set();
                    Thread.Sleep(Period);
                }
                MRM_Parallel_Data.Log(GetType().Name, true);
            });
            MainThread.Start();
           
        }

        Thread MainThread;
        Thread[] threads;

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
        public void Abort()
        {
            for (int i = 0; i < 5; i++)
            {
                events[i].Set();
            }
        }

    }
}
