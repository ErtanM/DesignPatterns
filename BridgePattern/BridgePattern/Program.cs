using System;

namespace BridgePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuestionFormat questions = new QuestionFormat("C# Programming Language :)");

        //calismiyo knaka direk hata , goruyo musun hatayi altta
            questions.q = new CSharpQuestions();

            questions.nextQuestion();
            questions.displayQuestion();
            questions.deleteQuestion("What is class?");
            questions.newQuestion("What is inheritance?");
            questions.newQuestion("How many types of inheritance are there in C#?");
            questions.displayAllQuestions();

            ///stopping for user to end
            Console.ReadLine();
        }
    }
}
