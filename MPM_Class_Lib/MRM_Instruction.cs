using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM_Class_Lib
{
    public class MRM_Instruction
    {
        private MRM_Instruction() { }
        public List<MRM_Frame> Frames { get; private set; } = new List<MRM_Frame>();
        public bool Error => !Frames.Any();
        public string ToPrint()
        {
            string result = "";
            if (Error) return result;
            Frames.ForEach(p => result += p.ToPrint());
            return result;
        }
        public static MRM_Instruction ProcessString(string instruction)
        {
            var instructions =
                instruction.Split(
                new[] { '\n', '\r', '\f' },
                StringSplitOptions.RemoveEmptyEntries
                )
                .Select(p => MRM_Frame.ProcessString(p))
                .OrderBy(p => p.FrameNum);
            ;

            int i = 1;
            foreach (var item in instructions)
            {
                if (item.FrameNum != i++ || item.Error) {
                    return new MRM_Instruction();
                }
            }


            return new MRM_Instruction {
                Frames = instructions.ToList()
            };
        }
    }
}
