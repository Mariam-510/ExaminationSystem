using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseOneAnswer : Answer
    {
        public ChooseOneAnswer(List<string> correctAnswer) : base(correctAnswer)
        {
        }

        public override bool SetUserAnswer(string answer, List<string> options)
        {
            if (string.IsNullOrEmpty(answer))
                return false;

            answer = answer.Replace(" ", "");

            if (!int.TryParse(answer, out int choice))
                return false;

            if (choice<1 || choice>options.Count)
                return false;

            userAnswer.Add(answer);

            return true;
        }

        public override bool IsCorrect()
        {
            return string.Equals(UserAnswer[0].Trim(), CorrectAnswer[0].Trim(), StringComparison.OrdinalIgnoreCase);
        }
    
    }
}
