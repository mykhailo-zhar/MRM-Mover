using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM_Class_Lib
{
    //Геометрия
    public class MRM_Instruction_Processor
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Speed { get; set; } = 0;
        public double Rotation_Position { get; set; } = 0;
        public double Arm_Bottom { get; set; } = 0;
        public double Arm_Top { get; set; } = 0;
        public double Rotation_Speed { get; set; } = 0;
        public bool Active_Grep { get; set; } = false;

        public void ProcessInstruction(MRM_Frame Frame)
        {
            if (Frame.Error) return;
            Frame.Commands.ForEach(command => {
                switch (command.Command)
                {
                    case MRM_Command_Enum.SetSpeed:
                        break;
                    case MRM_Command_Enum.SetX:
                        break;
                    case MRM_Command_Enum.SetY:
                        break;
                    case MRM_Command_Enum.SetRotationSpeed:
                        break;
                    case MRM_Command_Enum.SetUz:
                        break;
                    case MRM_Command_Enum.SetU1:
                        break;
                    case MRM_Command_Enum.SetU2:
                        break;
                    case MRM_Command_Enum.EnableManipulator:
                        break;
                    case MRM_Command_Enum.DisableManipulator:
                        break;
                    case MRM_Command_Enum.StopProgram:
                        break;
                }

            });
        }
    }
}
