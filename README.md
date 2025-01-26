# ExaminationSystem (Dec 2024)

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Description: The Examination System is designed to manage and conduct exams efficiently, supporting various types of questions and answers. The system is flexible enough to handle different types of exams, including Practice Exams and Final Exams, each with unique features.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Key Features
1. Question Management:
- Supports multiple question types: (True/False questions - Choose One questions - Choose All questions)
- Questions are represented by a base Question class with specialized inherited classes for each type.
2. Answer Representation:
- A dedicated Answer class manages answers for questions.
3. Exam Management:
- A base Exam class defines common attributes: (Exam time - Number of questions)
- A ShowExam() functionality (implemented differently in derived classes).
- Associated with a Subject object for specifying the exam's subject.
4. Exam Types:
- Practice Exam: Displays correct answers after completing the exam.
- Final Exam: Displays questions, possible answers, and grades without revealing correct answers during the exam.
