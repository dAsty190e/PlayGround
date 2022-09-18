using System;

namespace _09_FavoriteColor
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while will always run at least once
            // do while is good for aking when to terminate the program 
            var keepAlive = true;
            do 
            {
                // while loops will run a block of code while its exprassion is true 
                // while loops may not run if the expression is already true
                // [] = Array index syntax
                var colors = new string[5];
                colors[0] = "red";
                colors[1] = "blue";
                colors[2] = "green";
                colors[3] = "yellow";
                colors[4] = "black";

                Console.WriteLine("What is your favorite color?");

                for (int i = 0; i < colors.Length; i++)
                {
                    Console.WriteLine(colors[i]);
                }
                var userColor = Console.ReadLine();

                // while loop is good for retry
                while (userColor != "red" && userColor != "blue" && userColor != "green" && userColor != "yellow" && userColor != "black")
                {
                    Console.WriteLine("Invalid color, please try again!");
                    userColor = Console.ReadLine();
                }
                Console.WriteLine("Try again?");
                keepAlive = Console.ReadKey(true).Key == ConsoleKey.Y;
                
            } while (keepAlive);
        }
    }
}
