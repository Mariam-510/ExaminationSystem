using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Answer
    {
        public List<string> CorrectAnswer { get; set; }

        protected List<string> userAnswer;
        public List<string> UserAnswer
        {
            get { return userAnswer; }
        }

        public Answer(List<string> correctAnswer)
        {
            CorrectAnswer = correctAnswer;
            userAnswer = new List<string>();
        }

        public abstract bool SetUserAnswer(string answer, List<string> options);

        public abstract bool IsCorrect();

        public override string ToString()
        {
            return $"User Answer: {string.Join(",", UserAnswer)} - Correct Answer: {string.Join(",", CorrectAnswer)}";
        }

    }
}
