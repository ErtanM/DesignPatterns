using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class QuestionFormat : QuestionManager
    {
        public QuestionFormat(string catalog) : base(catalog)
        {

        }

        public override void displayAllQuestions()
        {
            Console.WriteLine("\n----------------------------------------");
            base.displayAllQuestions();
            Console.WriteLine("----------------------------------------");
        }

    }
}
