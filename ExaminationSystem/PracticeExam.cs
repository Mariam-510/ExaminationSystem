using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem 
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int timeInMinutes, Subject subject) 
            : base(timeInMinutes, subject)
        {
        }

        public PracticeExam(int timeInMinutes, Subject subject, List<Question> questions)
            : base(timeInMinutes, subject, questions)
        {
        }

        public override string ToString()
        {
            StringBuilder examStringBuilder = new StringBuilder();
            examStringBuilder.AppendLine("Practice Exam");
            examStringBuilder.AppendLine("-------------");
            examStringBuilder.AppendLine(base.ToString());

            return examStringBuilder.ToString();
        }

        public override string ShowExam()
        {
            StringBuilder examStringBuilder = new StringBuilder();
            examStringBuilder.AppendLine("Practice Exam Finished");
            examStringBuilder.AppendLine("----------------------");

            for (int i = 0; i < Questions.Count; i++)
            {
                if (Questions[i] != null)
                {
                    examStringBuilder.AppendLine($"{Questions[i]}");
                    examStringBuilder.Append($"{Questions[i].Answer}");
                    if (Questions[i].Answer.IsCorrect())
                        examStringBuilder.AppendLine(" [Matched]");
                    else
                        examStringBuilder.AppendLine(" [Not Matched]");

                    examStringBuilder.AppendLine("-----------------------------------------");
                    
                }
            }

            return examStringBuilder.ToString();
        }
    
    }
}
