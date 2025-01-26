namespace ExaminationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Questions

            #region Practice Exam Questions
            Subject subjectPracticeExam = new Subject("Math");
            List<Question> questionsPracticeExam = new List<Question>();
            
            questionsPracticeExam.Add(new TrueFalseQuestion("True or False", "Is 7 a prime number?", 1, new TrueFalseAnswer(new List<string> { "T" })));

            questionsPracticeExam.Add(new ChooseOneQuestion("Choice one option", "2 + 2 = ?", 1, new List<string> { "3", "4", "5" },
                new ChooseOneAnswer(new List<string> { "2" })));

            questionsPracticeExam.Add(new ChooseAllQuestion("Choice multiple options", "Choose all even numbers", 2,
                new List<string> { "1", "2", "3", "6" }, new ChooseAllAnswer(new List<string> { "2", "4" })));

            questionsPracticeExam.Add(new TrueFalseQuestion("True or False", "Is 10 an odd number?", 1, new TrueFalseAnswer(new List<string> { "F" })));

            questionsPracticeExam.Add(new ChooseOneQuestion("Choice one option", "Which is the largest num?", 2.0,
                new List<string> { "-7", "-10", "-8" }, new ChooseOneAnswer(new List<string> { "1" })));
            #endregion

            #region Final Exam Questions
            Subject subjectFinalExam = new Subject("English");
            List<Question> questionsFinalExam = new List<Question>();

            questionsFinalExam.Add(new TrueFalseQuestion("True or False", "Cat is a noun.", 1, new TrueFalseAnswer(new List<string> { "T" })));

            questionsFinalExam.Add(new ChooseOneQuestion("Choice one option", "The plural of Fox is .......", 1, new List<string> { "Foxs", "Foxes" },
                new ChooseOneAnswer(new List<string> { "2" })));

            questionsFinalExam.Add(new ChooseAllQuestion("Choice multiple options", "Which of the following are colors?", 2,
                new List<string> { "Red", "Run", "Blue", "Yellow" }, new ChooseAllAnswer(new List<string> { "1", "3", "4" })));

            questionsFinalExam.Add(new ChooseOneQuestion("Choice one option", "...... is amazing", 1.5, new List<string> { "It", "They", "You" },
                new ChooseOneAnswer(new List<string> { "1" })));

            questionsFinalExam.Add(new TrueFalseQuestion("True or False", "Beautiful is a verb.", 1, new TrueFalseAnswer(new List<string> { "F" })));

            questionsFinalExam.Add(new ChooseAllQuestion("Choice multiple options", "Which of the following are animals?", 2,
                new List<string> { "Tree", "Cat", "Dog", "River" }, new ChooseAllAnswer(new List<string> { "2", "3" })));

            questionsFinalExam.Add(new ChooseOneQuestion("Choice one option", "Which sentence is correct?", 1.5,
                new List<string> { "I goes to school.", "I go to school.", "I going to school." }, new ChooseOneAnswer(new List<string> { "2" })));
            #endregion

            #endregion


            #region Menu
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1) Practice Exam");
            Console.WriteLine("2) Final Exam");
            Console.WriteLine();
            Console.Write("Please select the exam type: ");

            int choice;
            bool flag = int.TryParse(Console.ReadLine(), out choice);
            while (!flag || (choice != 1 && choice != 2))
            {
                Console.Write("Invalid choice. Please enter 1 or 2: ");
                flag = int.TryParse(Console.ReadLine(), out choice);
            }

            Exam selectedExam;
            if (choice == 1)
                selectedExam = new PracticeExam(60, subjectPracticeExam, questionsPracticeExam);
            else
                selectedExam = new FinalExam(90, subjectFinalExam, questionsFinalExam);
            #endregion


            #region Exam Started
            Console.WriteLine();
            Console.Write(selectedExam);

            for (int i = 0; i < selectedExam.Questions.Count; i++)
            {
                if (selectedExam.Questions[i] != null)
                {
                    var question = selectedExam.Questions[i];
                    bool answerIsValid = false;
                    string userAnswer;

                    Console.WriteLine($"Q{i + 1}: {question}");

                    while (!answerIsValid)
                    {
                        Console.Write($"Enter your answer ({question.FormattedInput}): ");
                        userAnswer = Console.ReadLine();
                        answerIsValid = question.Answer.SetUserAnswer(userAnswer, question.Options);

                        if (!answerIsValid)
                        {
                            Console.WriteLine("Invalid answer format. Please try again.");
                        }
                    }
                }

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
            }
            #endregion


            #region Exam Finished Colored
            string result = selectedExam.ShowExam();
            string[] lines = result.Split("\n");

            foreach (string line in lines)
            {
                if (line.Contains("[Matched]"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(line);
                }
                else if (line.Contains("[Not Matched]"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(line);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(line);
                }
            }
            #endregion

        }
    }
}
