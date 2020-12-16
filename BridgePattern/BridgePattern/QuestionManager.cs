using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class QuestionManager : IQuestion
    {
        public IQuestion q;

        public string catalog;

        public QuestionManager(string catalog)
        {
            this.catalog = catalog;
        }


        public void deleteQuestion(string q)
        {
            this.q.deleteQuestion(q);
        }

        /// <summary>
        /// put virtual because cannot override in question format otherwise
        /// </summary>
        public virtual void displayAllQuestions()
        {
            Console.WriteLine($"Question Paper: {catalog}");
            q.displayAllQuestions();
        }

        public void displayQuestion()
        {
            q.displayQuestion();
        }

        public void newQuestion(string q)
        {
            this.q.deleteQuestion(q);
        }

        public void nextQuestion()
        {
            this.q.nextQuestion();
        }

        public void previousQuestion()
        {
            this.q.previousQuestion();
        }
    }
}
