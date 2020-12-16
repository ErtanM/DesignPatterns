using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public interface IQuestion
    {
        public void nextQuestion();
        public void previousQuestion();
        public void newQuestion(string q);
        public void deleteQuestion(string q);
        public void displayQuestion();
        public void displayAllQuestions();
    }
}
