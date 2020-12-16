using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{

    public class CSharpQuestions : IQuestion
    {
        private List<string> questions = new List<string>();

        private int current = 0;

            /// <summary>
            /// Constructor to get questions
            /// </summary>
        public CSharpQuestions()
        {
            questions.Add("What is class?");
            questions.Add("What is interface?");
            questions.Add("What is abstraction?");
            questions.Add("How multiple polymorphism is achived in C#?");
            questions.Add("How many types of exception handling are there in C#?");
            questions.Add("What is abstract class?");
            questions.Add("What is multi threading?");
        }

        public void deleteQuestion(string q) => questions.Remove(q);

        public void displayAllQuestions()
        {
            foreach (var item in questions)
            {
                Console.WriteLine(item);
            }
        }

        public void displayQuestion() => Console.WriteLine(questions[current]);

        public void newQuestion(string q) => questions.Add(q);

        public void nextQuestion()
        {
            if (current <= questions.Count - 1)
            {
                current++;
            }
        }

        public void previousQuestion()
        {
            if (current > 0)
            {
                current--;
            }
        }
    }
}
