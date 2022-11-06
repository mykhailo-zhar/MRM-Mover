using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MRM_Class_Lib;

namespace MRM_Class_Lib.Parser
{
    using MP = Movement_Processor;
    public class MRM_Instruction_Executer
    {
        public double Acceleration { get; set; } = 0.01;
        MRM_Instruction Instruction;
        public MP MCP_X { get; private set; }
        public MP MCP_Y { get; private set; }
        public MP MCP_Uz { get; private set; }
        public MP MCP_U1 { get; private set; }
        public MP MCP_U2 { get; private set; }

        public bool Active_Grep { get; private set; } = false;
        public double? X => MCP_X?.CurrentSpeed;
        public double? Y => MCP_Y?.CurrentSpeed;
        public double? Uz => MCP_Uz?.CurrentSpeed;
        public double? U1 => MCP_U1?.CurrentSpeed;
        public double? U2 => MCP_U2?.CurrentSpeed;
        double Speed = 0.0,
                Rotation_Speed = 0.0;

        bool Complete =>
                MCP_X.Completed &&
                MCP_Y.Completed &&
                MCP_Uz.Completed &&
                MCP_U1.Completed &&
                MCP_U2.Completed;
        public bool Completed => Instruction != null && !Instruction.Frames.Any() && Complete;
        bool NewFrame =>
               (MCP_X == null) &&
               (MCP_Y == null) &&
               (MCP_Uz == null) &&
               (MCP_U1 == null) &&
               (MCP_U2 == null);


        public void SetInstruction(MRM_Instruction instruction)
        {
            DeleteCurrentMovementProcessors();
            Instruction = instruction;
        }
        public void DeleteInstruction() => Instruction = null;
        public void ResetInstruction()
        {
            DeleteCurrentMovementProcessors();
            Instruction.Reset();
        }
        private void ProcessInstruction(MRM_Frame Frame)
        {
            double X = 0.0,
            Y = 0.0;

            double Rotation_Position = 0.0,
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
                            Speed = command.Value;
                            break;
                        case MRM_Command_Enum.SetX:
                            X += command.Value;
                            break;
                        case MRM_Command_Enum.SetY:
                            Y += command.Value;
                            break;
                        case MRM_Command_Enum.SetRotationSpeed:
                            Rotation_Speed = command.Value;
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
                            Active_Grep = true;
                            break;
                        case MRM_Command_Enum.DisableManipulator:
                            Active_Grep = false;
                            break;
                        case MRM_Command_Enum.StopProgram:
                            break;
                    }

                });
            }
            MCP_X = new MP(Acceleration, Speed, X);
            MCP_Y = new MP(Acceleration, Speed, Y);

            MCP_Uz = new MP(Acceleration, Rotation_Speed, Rotation_Position);
            MCP_U1 = new MP(Acceleration, Rotation_Speed, U1);
            MCP_U2 = new MP(Acceleration, Rotation_Speed, U2);
        }

        private void Move()
        {
            if (!MCP_X.Completed) MCP_X.Move();
            if (!MCP_Y.Completed) MCP_Y.Move();
            if (!MCP_U1.Completed) MCP_U1.Move();
            if (!MCP_U2.Completed) MCP_U2.Move();
            if (!MCP_Uz.Completed) MCP_Uz.Move();
        }

        private void DeleteCurrentMovementProcessors()
        {
            MCP_X = null;
            MCP_Y = null;
            MCP_Uz = null;
            MCP_U1 = null;
            MCP_U2 = null;
        }

        public void ProcessStep()
        {
            if (Instruction.Error || Instruction == null) return;

            if (NewFrame || Complete)
            {
                if (!Instruction.Frames.Any()) return;
                var Frame = Instruction.Frames.Dequeue();
                ProcessInstruction(Frame);
            }
            if (!Complete)
            {
                Move();
            }
        }

        public string ToPrint() => Instruction.ToPrint();
    }
}
