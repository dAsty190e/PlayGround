using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool - its "true" or "false"
            bool success = false;

            Console.WriteLine("What is your age?");
            //input is a box / Console.Readline go to the box
            string input = Console.ReadLine();
            // int.Parse convert string to a number
            int age = int.Parse(input);

            //age check (if - else)
            if (age < 16)
            {
                Console.WriteLine("You are just not old enough!");
            }
            else if (age < 18)
            {
                Console.WriteLine("Do you have parental consent? Y/N");
                char parentalConcent = Console.ReadKey().KeyChar;
                // || - or
                // && - and 
                // $ - interpolate
                // \n - brake line
                if (parentalConcent == 'Y' || parentalConcent == 'y')
                {
                    //Console.WriteLine("\nThank you! You can reecive your driver licence!");
                    success = true;
                }
                // char.ToLower make all letters lower case -(if its ASD it will be asd) 
                else if (char.ToLower(parentalConcent) == 'n')
                {
                    //Console.WriteLine("\nSorry, you need parental consent!");
                }
                else
                {
                    Console.WriteLine($"\nInvalid character! {parentalConcent}");
                    Console.WriteLine("\nOnly Y/y or N/n is allowed");  
                }
            }
            // < - less
            // > - more / greater
            // >65 allowed \\ >=65 not allowed
            else if (age >= 65)
            {
                //Console.WriteLine("\nSorry, you are too old bro!");
            }
            else
            {
                //Console.WriteLine("\nThis is your driver license!");
            }
            // this is a cleaner way to write a code (success) DRY - dont reapet yourself
            if (success)
            {
                Console.WriteLine("\nHere you drivers license!");
            }
            else
            {
                Console.WriteLine("\nNot today bro!");
            }
        }
    }
}
