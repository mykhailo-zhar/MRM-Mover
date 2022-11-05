using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MRM_Class_Lib.Parser;

namespace MRM_Class_Lib
{
    //Геометрия
    using MCP = MRM_Command_Processor;
    public class Geometry_Processor
    {
        public MRM_Instruction Instruction { get; set; }

        public static double Acceleration = 10.0; 

        MCP MCP_X,
            MCP_Y,
            MCP_Uz,
            MCP_U1,
            MCP_U2;

        bool Active_Grep = false;

        public void ProcessInstruction(MRM_Frame Frame)
        {
            double Speed = 0.0,
            X = 0.0,
            Y = 0.0;

            double Rotation_Speed = 0.0,
            Rotation_Position = 0.0,
            U1 = 0.0,
            U2 = 0.0;

            Active_Grep = false;

            if (!Frame.Error)
            {
                Frame.Commands.ForEach(command =>
                {
                    switch (command.Command)
                    {
                        case MRM_Command_Enum.SetSpeed:
                            Speed += command.Value;
                            break;
                        case MRM_Command_Enum.SetX:
                            X += command.Value;
                            break;
                        case MRM_Command_Enum.SetY:
                            Y += command.Value;
                            break;
                        case MRM_Command_Enum.SetRotationSpeed:
                            Rotation_Speed += command.Value;
                            break;
                        case MRM_Command_Enum.SetUz:
                            Rotation_Position += command.Value;
                            break;
                        case MRM_Command_Enum.SetU1:
                            U1 += command.Value;
                            break;
                        case MRM_Command_Enum.SetU2:
                            U2 += command.Value;
                            break;
                        case MRM_Command_Enum.EnableManipulator:
                            Active_Grep &= true;
                            break;
                        case MRM_Command_Enum.DisableManipulator:
                            Active_Grep &= false;
                            break;
                        case MRM_Command_Enum.StopProgram:
                            break;
                    }

                });
            }
            MCP_X = new MCP(Acceleration, Speed, X);
            MCP_Y = new MCP(Acceleration, Speed, Y);

            MCP_Uz = new MCP(Acceleration, Rotation_Speed, Rotation_Position);
            MCP_U1 = new MCP(Acceleration, Rotation_Speed, U1);
            MCP_U2 = new MCP(Acceleration, Rotation_Speed, U2);
        }
        
        public void GeometryProcess()
        {
            while (true)
            {
                //TODO: Событие на сигнал остановки/продолжения
                if (Instruction == null || Instruction.Error) continue;

                var Frame = Instruction.Frames.Dequeue();
                ProcessInstruction(Frame);

            }
        }

    }
}
