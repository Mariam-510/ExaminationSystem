using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string header, string body, double marks, List<string> options, Answer answer)
            : base(header, body, marks, options, answer)
        {
            FormattedInput = $"Choose Nums of Correct Options From 1 to {options.Count} Sperated by Comma";
        }
        public override string ToString()
        {
            StringBuilder questionStringBuilder = new StringBuilder();
            questionStringBuilder.AppendLine(base.ToString());

            for (int i = 0; i < Options.Count; i++)
            {
                questionStringBuilder.AppendLine($"{i + 1}. {Options[i]}");
            }

            return questionStringBuilder.ToString();

        }
    
    }
}
