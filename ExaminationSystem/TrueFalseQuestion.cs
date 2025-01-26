using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem 
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, double marks, Answer answer)
            : base(header, body, marks, new List<string> { "T", "F", "True", "False" }, answer)
        {
            FormattedInput = "T/True or F/False";
        }

        public override string ToString()
        {
            return base.ToString() + "\n";
        }

    }
}
