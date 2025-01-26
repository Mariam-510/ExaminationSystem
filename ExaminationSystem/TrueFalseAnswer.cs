using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem 
{
    public class TrueFalseAnswer : Answer
    {
        public TrueFalseAnswer(List<string> correctAnswer) : base(correctAnswer)
        {
        }

        public override bool SetUserAnswer(string answer, List<string> options)
        {
            if (string.IsNullOrEmpty(answer))
                return false;

            answer = answer.Replace(" ", "");

            bool contain = false;
            for (int i = 0; i < options.Count; i++)
            {
                if (string.Equals(options[i], answer, StringComparison.OrdinalIgnoreCase))
                {
                    contain = true;
                    break;
                }
            }
            if (!contain)
                return false;

            userAnswer.Add(answer);

            return true;
        }

        public override bool IsCorrect()
        {
            string correct = CorrectAnswer[0].Trim().ToLower();
            string user = UserAnswer[0].Trim().ToLower();

            if ((correct == "t" || correct == "true") && (user == "t" || user == "true"))
                return true;

            if ((correct == "f" || correct == "false") && (user == "f" || user == "false"))
                return true;

            return false;
        }

    }
}
