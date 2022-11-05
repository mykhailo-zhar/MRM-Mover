using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MRM_Class_Lib.Parser
{
    public class MRM_Frame
    {
        public uint FrameNum { get; private set; } = 0;
        public bool Error => FrameNum == 0;
        public bool Last { get; internal set; } = false;
        public List<MRM_Command> Commands { get; private set; } = new List<MRM_Command>();
        //TODO: Представление кадра в виде чисел

        //TODO: Функция ускорения торможения для перемещения и вращения 
        private MRM_Frame() { }
        public string ToPrint()
        {
            if (Error) return "";

            int count_num = 1;
            uint frame_num_copy = FrameNum;
            while((frame_num_copy/=10)>0) { count_num++; }
            string result = $"N{new string('0',10-count_num)}{FrameNum}";
            Commands.ForEach(p => result += $" {p.ToPrint()}");
            return result + "\r\n";
        }

        public static MRM_Frame ProcessString(string frame)
        {
            if(!Regex.IsMatch(frame, @"^(N\d+)([ \t]+(([FXYSABCM])-??\d+))+[ \t]*$"))
            {
                return new MRM_Frame { };
            }
            var frame_commands =
                frame.Split(
                new[] { ' ', '\t', },
                StringSplitOptions.RemoveEmptyEntries
                );

            uint num = uint.Parse(frame_commands[0].Substring(1));

            if (frame_commands.Length < 2 || frame_commands[0][0] != 'N' || num == 0)
            {
                return new MRM_Frame { };
            }

            List<MRM_Command> list = new List<MRM_Command>();
            bool last = false;

            for (int i = 1; i < frame_commands.Length; i++)
            {
                var command = MRM_Command.ProcessString(frame_commands[i]);
                list.Add(command);
                if (command.Last) { last = true; break; }
                if (command.Error)
                {
                    return new MRM_Frame();
                }
            }

            return new MRM_Frame { 
                FrameNum = num,
                Commands = list,
                Last = last
            };
        }
    }
}
