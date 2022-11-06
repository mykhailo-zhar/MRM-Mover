using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRM_Class_Lib.Parser
{
    public class MRM_Instruction
    {
        private MRM_Instruction() { }
        public Queue<MRM_Frame> Frames { get; private set; } = new Queue<MRM_Frame>();
        private List<MRM_Frame> InstructionFrames = new List<MRM_Frame>();

        public bool Complited => Frames.Count == 0;
        public bool Error => !InstructionFrames.Any();


        public string ToPrint()
        {
            string result = "";
            if (Error) return result;
            InstructionFrames.ForEach(p => result += p.ToPrint());
            return result;
        }
        public void Reset() => Frames = new Queue<MRM_Frame>(InstructionFrames);
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

            if (!instruction.Any()) return new MRM_Instruction();

            int i = 1;
            var instructions_list = new List<MRM_Frame>();
            foreach (var item in instructions)
            {
                instructions_list.Add(item);
                if(item.Last) { break; }
                if (item.FrameNum != i++ || item.Error) {
                    return new MRM_Instruction();
                }
            }
            instructions_list.Last().Last = true;

            return new MRM_Instruction {
                InstructionFrames = new List<MRM_Frame>(instructions_list),
                Frames = new Queue<MRM_Frame>(instructions_list)
            };
        }
    
        public static MRM_Instruction ManualInstruction(
            double speed, 
            double x,
            double y,
            double rotation_speed,
            double uz,
            double u1,
            double u2,
            bool grep
            )
        {
            var Result = new MRM_Instruction
            {
                InstructionFrames = new List<MRM_Frame>
                {
                    MRM_Frame.ProcessString($"N1 F{speed, 0:f0} S{rotation_speed, 0:f0} X{x, 0:f0} Y{y, 0:f0} A{uz, 0:f0} B{u1, 0:f0} C{u2, 0:f0} M0{(grep?3:4)} M02")
                } 
            };
            Result.InstructionFrames[0].Last = true;
            Result.Reset();
            return Result;
        }
    }
}
