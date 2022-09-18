using System;

namespace _11_MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
            string userInput;
            int parsedInt;


            Console.WriteLine("what is 5+5 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 10)
            {
                correct++;
            }

            Console.WriteLine("what is 6+5 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 11)
            {
                correct++;
            }

            Console.WriteLine("what is 7.3+2.7 = ?");
            userInput = Console.ReadLine();
            _ = float.TryParse(userInput, out float numThree);
            if (numThree == 10)
            {
                correct++;
            }

            Console.WriteLine("what is 10+7 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 17)
            {
                correct++;
            }

            Console.WriteLine("what is 1+11 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 12)
            {
                correct++;
            }

            Console.WriteLine("what is 12-5 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 7)
            {
                correct++;
            }

            Console.WriteLine("what is 21/7 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 3)
            {
                correct++;
            }

            Console.WriteLine("what is 5-1 = ?");
            userInput = Console.ReadLine();
            _ = int.TryParse(userInput, out parsedInt);
            if (parsedInt == 4)
            {
                correct++;
            }

            Console.WriteLine("what is 6*6 = ?");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out parsedInt);
            if (parsedInt == 36)
            {
                correct++;
            }

            Console.WriteLine("what is 7*8 = ?");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out parsedInt);
            if (parsedInt == 55)
            {
                correct++;
            }

            Console.WriteLine($"You got {correct} correct");
        }
    }
}
