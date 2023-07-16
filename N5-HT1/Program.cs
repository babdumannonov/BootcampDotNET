using System;

namespace BootcampDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            string[] questions = new string[5]
            {
                "What is the alternative for else-if?\nA) Switch Case\nB) Switch Expression",
                "What is .NET?\nA) Free, open-source, cross-platform framework\nB) Programming language",
                "When was C# created?\nA) 2002\nB) 2000",
                "Who is the owner of Twitter?\nA) Elon Musk\nB) Jeff Bezos",
                "Who is the owner of Amazon?\nA) Mark Zuckerberg\nB) Jeff Bezos"
            };

            string[] rightAnswers = new string[5] { "A", "A", "B", "A", "B" };
            string[] userAnswers = new string[5];
            int[] scores = new int[5];
            int totalScore = 0;
            int invalidAnswers = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Question {0}:", i + 1);
                Console.WriteLine(questions[i]);
                Console.Write("Your Answer: ");
                userAnswers[i] = Console.ReadLine();

                if (userAnswers[i] == rightAnswers[i])
                {
                    scores[i] = 1;
                    totalScore++;
                }
                else
                {
                    scores[i] = 0;
                    invalidAnswers++;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Test Results:");
            Console.WriteLine("==============");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Question {0}:", i + 1);
                Console.WriteLine("Your Answer: {0}", userAnswers[i]);
                Console.WriteLine("Correct Answer: {0}", rightAnswers[i]);
                Console.WriteLine("Score: {0}", scores[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Total Score: {0}", totalScore);
            Console.WriteLine("Invalid Answers: {0}", invalidAnswers);
        }
    }
}
