using System;

namespace _001_Variables_Trainig_
{
    class Program
    {
        static void Main(string[] args)
        {
            // var - var can gues all types when its assign. --- int, bool, string and else. (cant be assign to null)

            // int one = 1;

            // bool myBool = true;
            // ^   ^   ^   ^   ^ - instanse - its a variable that has a value.  (whole line that containe type name and value)

            // string yourName = "";
            // bool nano = yourName.Contains("lo");

            //int mimo;

            

            Console.WriteLine("Say your name");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}");
            Console.WriteLine($"{name} having a great day? y/n");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            ConsoleKey key = consoleKeyInfo.Key;

            if (key == ConsoleKey.Y)
            {
                Console.WriteLine($"Good to hear it {name}");
            }
            else if (key == ConsoleKey.N)
            {
                Console.WriteLine("thats bad" + name);
            }


        }
    }
}
