using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseAllAnswer : Answer
    {
        public ChooseAllAnswer(List<string> correctAnswer) : base(correctAnswer)
        {
        }

        public override bool SetUserAnswer(string answer, List<string> options)
        {
            if (string.IsNullOrEmpty(answer))
                return false;

            string[] arr = answer.Replace(" ", "").Split(',');

            HashSet<string> uniqueAnswers = new HashSet<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueAnswers.Add(arr[i]))
                    return false;

                if (!int.TryParse(arr[i], out int choice))
                    return false;

                if (choice < 1 || choice > options.Count)
                    return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                userAnswer.Add(arr[i]);
            }

            return true;
        }

        public override bool IsCorrect()
        {
            if (UserAnswer.Count != CorrectAnswer.Count)
                return false;

            for (int i = 0; i < UserAnswer.Count; i++)
            {
                bool contain = false;
                foreach (string correctAnswer in CorrectAnswer)
                {
                    if (string.Equals(correctAnswer.Trim(), UserAnswer[i].Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        contain = true;
                        break;
                    }
                }
                if (!contain) 
                    return false;

            }

            return true;
        }
    
    }
}
