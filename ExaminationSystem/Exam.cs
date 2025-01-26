using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public double TimeInMinutes { get; set; }
        public int NumberOfQuestions { get => Questions.Count; }
        public List<Question> Questions { get; set; }
        public Subject ExamSubject { get; set; }

        public Exam(int timeInMinutes, Subject subject)
        {
            TimeInMinutes = timeInMinutes;
            ExamSubject = subject;
            Questions = new List<Question>();
        }

        public Exam(int time, Subject subject, List<Question> questions)
            : this(time, subject)
        {
            Questions = questions;
        }

        public abstract string ShowExam();

        public override string ToString()
        {
            StringBuilder examStringBuilder = new StringBuilder();

            examStringBuilder.AppendLine($"Subject: {ExamSubject.Name}");
            examStringBuilder.AppendLine($"Time: {TimeInMinutes} minutes");
            examStringBuilder.AppendLine($"Number of Questions: {NumberOfQuestions}");

            return examStringBuilder.ToString();
        }
    
    }
}
