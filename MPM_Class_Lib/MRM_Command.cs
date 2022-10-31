using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MRM_Class_Lib
{
    public enum MRM_Command_Enum
    {
        SetSpeed,
        SetX,
        SetY,
        SetRotationSpeed,
        SetUz,
        SetU1,
        SetU2,
        EnableManipulator,
        DisableManipulator,
        StopProgram,
        Error
    }
    public class MRM_Command
    {
        private MRM_Command() { }
        public MRM_Command_Enum Command { get; private set; }
        public bool Error => Command == MRM_Command_Enum.Error;
        public double Value { get; set; }

        public string ToPrint()
        {
            string Result = "";
            switch (Command)
            {
                case MRM_Command_Enum.SetSpeed:
                    Result += "F" ;
                    break;
                case MRM_Command_Enum.SetX:
                    Result += "X";
                    break;
                case MRM_Command_Enum.SetY:
                    Result += "Y";
                    break;

                case MRM_Command_Enum.SetRotationSpeed:
                    Result += "S";
                    break;
                case MRM_Command_Enum.SetUz:
                    Result += "A";
                    break;
                case MRM_Command_Enum.SetU1:
                    Result += "B";
                    break;
                case MRM_Command_Enum.SetU2:
                    Result += "C";
                    break;

                case MRM_Command_Enum.EnableManipulator:
                    return "M03";
                case MRM_Command_Enum.DisableManipulator:
                    return "M04";
                case MRM_Command_Enum.StopProgram:
                    return "M05";
                default:
                    return Result;
            }
            Result += $"{Value}";

            return Result;
        }

        public static MRM_Command ProcessString(string command)
        {
            var Result = new MRM_Command()
            {
                Command = MRM_Command_Enum.Error,
            };

            if (
                Regex.IsMatch(command, @"^([FXYSABCM])-??\d+$") &&
                command.Length < 2
                )
            {
                return Result;
            }


            switch (command[0])
            {
                case 'F':
                    Result.Command = MRM_Command_Enum.SetSpeed;
                    break;
                case 'X':
                    Result.Command = MRM_Command_Enum.SetX;
                    break;
                case 'Y':
                    Result.Command = MRM_Command_Enum.SetY;
                    break;

                case 'S':
                    Result.Command = MRM_Command_Enum.SetRotationSpeed;
                    break;
                case 'A':
                    Result.Command = MRM_Command_Enum.SetUz;
                    break;
                case 'B':
                    Result.Command = MRM_Command_Enum.SetU1;
                    break;
                case 'C':
                    Result.Command = MRM_Command_Enum.SetU2;
                    break;

                case 'M':
                    if (command == "M03")
                        Result.Command = MRM_Command_Enum.EnableManipulator;
                    else if (command == "M04")
                        Result.Command = MRM_Command_Enum.DisableManipulator;
                    else if (command == "M02")
                        Result.Command = MRM_Command_Enum.StopProgram;
                    return Result;
                default:
                    return Result;

            }

            Result.Value = long.Parse(command.Substring(1));


            return Result;
        }

    }
}
