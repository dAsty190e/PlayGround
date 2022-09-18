using System;
using System.Collections.Generic;
namespace _006_List2_Training_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's your list! To add press - A, remove press - R, cancel program press - X");
            bool reapeat = true;
            ConsoleKey userInput;
            string addItem;
            string removeItem;
            List<string> myList = new List<string>();
            do
            {
                userInput = Console.ReadKey().Key;
                switch (userInput)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Add your things");
                        addItem = Console.ReadLine();
                        myList.Add(addItem); 
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("Remove your things");
                        removeItem = Console.ReadLine();
                        myList.Remove(removeItem);
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("See you later");
                        reapeat = !reapeat;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                myList.Sort();
                int number = 1;
                foreach (var item in myList)
                {
                    Console.WriteLine($"{number++}. {item}");
                }
            } while (reapeat);
        }
    }
}
