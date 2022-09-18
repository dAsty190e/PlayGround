using System;

namespace _002_Switch_Training_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hi! What are you serching for?");
            var answers = Console.ReadLine();
            
            switch (answers)
            {
                case "dog":
                case "cat":
                case "rat":
                    Console.WriteLine("We will get to them!");
                    break;
                case "car":
                case "bike":
                    Console.WriteLine("Did you want to buy it? y/n");
                    var buy = Console.ReadLine();

                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                    ConsoleKey key = consoleKeyInfo.Key;

                    if (key == ConsoleKey.Y)
                    {
                        Console.WriteLine("");
                    }
                    else if (key == ConsoleKey.N)
                    {
                        Console.WriteLine("");
                    }

                    Console.WriteLine("\nGreat! Lets do it!");
                    break;
                default:
                    Console.WriteLine("See you later!");
                    break;
            }
        }
    }
}
