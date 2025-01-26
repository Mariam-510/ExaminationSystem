using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        public List<string> Options { get; set; }
        public Answer Answer { get; set; }
        public string FormattedInput { get; set; }

        public Question(string header, string body, double marks, List<string> options, Answer answer)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Options = options;
            Answer = answer;
        }

        public override string ToString()
        {
            return $"{Header}: {Body} ({Marks} Mark)";
        }

    }
}
