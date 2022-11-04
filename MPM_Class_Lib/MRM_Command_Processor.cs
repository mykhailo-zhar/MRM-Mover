using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM_Class_Lib
{
    public class MRM_Command_Processor
    {
        /// <summary>
        /// Инициализация обработчика для перемещения
        /// </summary>
        /// <param name="Accelaration">Ускорение двигателя в мм/сек^2</param>
        /// <param name="Speed">Требуемая скорость в мм/сек</param>
        /// <param name="Distance">Требуемое расстояние в мм</param>
        /// <param name="Modifier">Коэффициент перевода</param>
        public MRM_Command_Processor(double Acceleration, double Speed, double Distance, double Modifier = 1000.0)
        {
            this.Acceleration = Acceleration * Modifier;
            this.Speed = Speed * Modifier;

            Direction = Distance >= 0 ? 1.0 : -1.0;

            this.Distance = Math.Abs(Distance) * Modifier;
        }

        public double Acceleration { get; private set; }
        public double Speed { get; private set; }
        public double CurrentSpeed { get; private set; } = 0;
        public double Distance { get; private set; }
        public double CurrentDistance { get; private set; } = 0;
        public bool Completed => CurrentDistance == Distance;

        private double BrakingDistance = 0;
        private double Direction = 0;
        private double Tacts = 0;


        private bool Braking = false;

        public void Move()
        {
            if (Completed)
                return;

            double ToMove = Math.Abs(Distance - CurrentDistance);
            if (ToMove <= BrakingDistance + Math.Abs(CurrentSpeed) && !Braking)
            {
                Braking = true;
                Acceleration = 2.0 * (Math.Abs(CurrentSpeed) * Tacts - ToMove) / Tacts / (Tacts + 1);

                if (Acceleration == 0 || double.IsInfinity(Acceleration)) Acceleration = 1.0;
            }

            if (!Braking)
            {
                if (Math.Abs(CurrentSpeed) < Speed)
                {
                    if (Math.Abs(CurrentSpeed + Direction * Acceleration) > Speed)
                    {
                        CurrentSpeed = Direction * Speed;
                    }
                    else
                    {
                        CurrentSpeed += Direction * Acceleration;
                        BrakingDistance += Math.Abs(CurrentSpeed);
                        ++Tacts;
                    }
                }
            }
            else
            {
                if (ToMove <= Acceleration)
                    CurrentSpeed = Direction * ToMove;
                else
                    CurrentSpeed -= Direction * Acceleration;

                if (Math.Abs(CurrentDistance + CurrentSpeed) > Math.Abs(Distance))
                {
                    CurrentSpeed = Direction * Math.Abs(Math.Abs(CurrentDistance) - Math.Abs(Distance));
                }
            }

            CurrentDistance += Math.Abs(CurrentSpeed);

        }
    }
}
