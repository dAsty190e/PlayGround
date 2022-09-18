using System;

namespace _003_Parsing_Training_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var parseA = true;
            //var bibi = true;
            //var nimo = true;

            //while (nimo)
            //{
            //    Console.WriteLine("give me a number");
            //    var numberR = Console.ReadLine();
            //    var numberT = int.Parse(numberR);
            //    Console.WriteLine(numberT *12);
            //}

            //while (parseA)
            //{
            //    Console.WriteLine("Give me youro number and I will double it");
            //    string number = Console.ReadLine();
            //    var numberA = int.Parse(number);
            //    Console.WriteLine(numberA * 10);

            //}

            //while (bibi)
            //{
            //    Console.WriteLine("Give me a number");
            //    var bla = Console.ReadLine();
            //    var blaB = float.Parse(bla);
            //    Console.WriteLine(blaB + 400.342);

            //}

            var again = false;

            do
            {
                string name;
                int correct = 0;
                string userPut;
                int answerInt;
                float answerFloat;
                // bool isParsed = false;

                Console.WriteLine("What is you name?");
                name = Console.ReadLine();
                Console.WriteLine($"Good to see you {name}! Lets as star our math!");

                #region Q1
                Console.WriteLine("What is 23.7 + 27.3 = ?");
                userPut = Console.ReadLine();
                var isParsed = float.TryParse(userPut, out answerFloat);
                while (!isParsed)
                {
                    Console.WriteLine($"{userPut} is not valid!\n What is 23.7 + 27.3 = ?");
                    userPut = Console.ReadLine();
                    isParsed = float.TryParse(userPut, out answerFloat);
                }

                if (answerFloat == 23.7 + 27.3)
                {
                    correct++;
                }
                #endregion

                #region Q2
                do
                {
                    Console.WriteLine("What is 35 - 10 = ?");
                    userPut = Console.ReadLine();
                    isParsed = int.TryParse(userPut, out answerInt);
                } while (!isParsed);

                if (answerInt == 35 - 10)
                {
                    correct++;
                }
                #endregion

                Console.WriteLine("What is 76 * 3 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 76 * 3)
                {
                    correct++;
                }

                Console.WriteLine("What is 25 * 100 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 25 * 100)
                {
                    correct++;
                }

                Console.WriteLine("What is 36 / 6 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 36 / 6)
                {
                    correct++;
                }

                Console.WriteLine("What is 40 * 25 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 40 * 25)
                {
                    correct++;
                }

                Console.WriteLine("What is 64 - 7 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 64 - 7)
                {
                    correct++;
                }

                Console.WriteLine("What is 86 - 4 = ?");
                userPut = Console.ReadLine();
                int.TryParse(userPut, out answerInt);

                if (answerInt == 86 - 4)
                {
                    correct++;
                }


                Console.WriteLine($"You got {correct} correct answers");

                if (correct > 6)
                {
                    Console.WriteLine($"Congrats {name}! You know math good!");
                }
                else  // if (correct < 6)
                {
                    Console.WriteLine($"{name} you need learn math!");
                }

                Console.WriteLine($"{name}, do you want to try again? y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                ConsoleKey key = consoleKeyInfo.Key;

                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine("Lets do it!");
                    again = true;
                }
                else
                {
                    Console.WriteLine("See you later!");
                    again = false;
                }
                //else if (key == ConsoleKey.N)
                //{
                //    Console.WriteLine("See you later!");
                //    again = false;
                //}

            } while (again);
        }
    }
}
