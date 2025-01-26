using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem 
{
    public class FinalExam : Exam
    {
        public double Grade { get; set; }

        public FinalExam(int timeInMinutes, Subject subject)
            : base(timeInMinutes, subject)
        {
            Grade = 0;
        }
        public FinalExam(int timeInMinutes, Subject subject, List<Question> questions)
            : base(timeInMinutes, subject, questions)
        {
            Grade = 0;
        }

        public override string ToString()
        {
            StringBuilder examStringBuilder = new StringBuilder();
            examStringBuilder.AppendLine("Fianl Exam");
            examStringBuilder.AppendLine("------------");
            examStringBuilder.AppendLine(base.ToString());

            return examStringBuilder.ToString();
        }

        public override string ShowExam()
        {
            StringBuilder examStringBuilder = new StringBuilder();

            examStringBuilder.AppendLine("Fianl Exam Fisished");
            examStringBuilder.AppendLine("-------------------");

            double total = 0;

            for (int i = 0; i < Questions.Count; i++)
            {
                if (Questions[i] != null)
                {
                    examStringBuilder.AppendLine($"{Questions[i]}");
                    examStringBuilder.Append($"Your Answer: {string.Join(",", Questions[i].Answer.UserAnswer)}");
                    if (Questions[i].Answer.IsCorrect())
                    {
                        Grade += Questions[i].Marks;
                        examStringBuilder.AppendLine(" [Matched]");
                    }
                    else
                        examStringBuilder.AppendLine(" [Not Matched]");

                    examStringBuilder.AppendLine("-----------------------------------------");
                    total += Questions[i].Marks;

                }
            }

            examStringBuilder.AppendLine($"Your Grade: {Grade} of {total}");

            return examStringBuilder.ToString();
        }
    
    }
}
