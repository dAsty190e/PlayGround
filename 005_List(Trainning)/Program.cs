using System;
using System.Collections.Generic;

namespace _005_List_Trainning_
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = true;
            string addPoop;
            List<string> poopList = new List<string>();
            do
            {
                Console.WriteLine("Add things to your list");
                Console.WriteLine("O - add item, X - remove item. If you want to close app press - C");
                var userP = Console.ReadLine();
                if (userP.ToLower() == "o")
                {
                    Console.WriteLine("What you want to add?");
                    addPoop = Console.ReadLine();
                    poopList.Add(addPoop);
                }
                else if (userP.ToLower() == "x")
                {
                    Console.WriteLine("What you want to remove?");
                    addPoop = Console.ReadLine();
                    var numberCheck = int.TryParse(addPoop, out var index);
                    if (numberCheck)
                    {
                        if (index < 1 || index > poopList.Count)
                        {
                            Console.WriteLine("Not valid");
                        }
                        else
                        {
                            poopList.RemoveAt(index - 1);
                        }
                    }
                    else
                    {
                        poopList.Remove(addPoop);
                    }
                }
                else if (userP.ToLower() == "c")
                {
                    list = false;
                }
                int number = 1;
                foreach (var item in poopList)
                {
                    Console.WriteLine($"{number++}. {item}");
                }
            } while (list);
        }
    }
}
