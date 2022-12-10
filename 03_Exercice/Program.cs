using System;

namespace _03_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = DateTime.Today.AddHours(0).AddMinutes(1).AddSeconds(1).TimeOfDay.Milliseconds;
            Console.WriteLine("Hi. My name is WALL'E!");

            bool success = false;

            Console.WriteLine("\nWhat is your name?");
            string input = Console.ReadLine();
            var name = input;

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"\nNice To meet you! {name}");
            }

            Console.WriteLine("\nDid you know my friend cockroach? Yes/No");
            char cockroach = Console.ReadKey().KeyChar; 
            if (char.ToLower(cockroach) == 'y')
            {
                Console.WriteLine("\nCHIRRRRRP");

                Console.WriteLine("\nOh! He so like to play! Come quick! Did you coming? yes/no");
                Console.ReadKey();

                Console.WriteLine("\nDid you see? Its him! My dear friend! yes/no");
                Console.ReadKey();

                Console.WriteLine("\nPrepare yourself to travel to another galaxy!");
                Console.Beep();
            }
            else if (char.ToLower(cockroach) == 'n')
            {
                Console.WriteLine("\nCome! He waiting on us! Did you coming? Y/N");
                cockroach = Console.ReadKey().KeyChar;

                if (char.ToLower(cockroach) == 'y')
                {
                    Console.WriteLine("\nOh! He so like to play! Come quick! Did you coming? yes/no");
                    Console.ReadKey();
                    Console.WriteLine("\nDid you see? Its him! My dear friend!");
                    Console.Beep();
                }
                else
                //if (char.ToLower(cockroach) == 'n')
                {
                    Console.WriteLine("\nOk! Mayby U can meet him next time!");
                    Console.Beep();
                    Console.WriteLine("\nWhen can you meet him? s/m/t/w/th/f/sa");
                    string time = Console.ReadLine();
                    time = time.ToLower();

                    if (time == "s" || time == "sa")
                    {
                        Console.WriteLine("\nCool! Lets party!");
                    }
                    else if (time == "m" || time == "t" || time == "w" || time =="th")
                    {
                        Console.WriteLine("\nOoooo! He is working hard!");
                    }
                    else
                    {
                        Console.WriteLine("\nWhat?? You drunk???");
                    }
                }
            }
        }
    }
}
