using System;

namespace _12_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize int variable
            var myNumber = 4;
            // declare type string variable
            string myString;
            // assign myString
            myString = "cat";

            // arrays are typed collections of values
            string[] myStrings = new string[] { "dog", "cat" };
            int[] myNumbers = new int[] { 1, 2, 3, myNumber };
            bool[] myBools = new bool[] {true, false, true };
            var myDoubles = new double[] { 123.4, 141.1, 12};

            // if/else if - is a control flow structure
            bool isFalse =  false;

            if (isFalse)
            {
                Console.WriteLine("Will run if true");
            }
            else 
            {
                Console.WriteLine("Will run if false");   
            }

            //switches are also control flow  structures
            string cat = "cat";
            switch (cat)
            {
                case "cat":
                    Console.WriteLine("Is cat");
                    break;
                case "dog":
                    Console.WriteLine("Is dog");
                    break;
                default:
                    Console.WriteLine("No case match");
                    break;
            }

            // while loops are iteration loops
            var sunShine = "sun";
            while (sunShine == "sun")
            {
                // repeat
                Console.WriteLine("Loop");
                sunShine = "rain";
            }

            // do {} while() loops - its iteration loops
            // they will run at least once
            do
            {
                Console.WriteLine("Loop");
            } while (sunShine == "sun");

            // for loops are iteration loops
            // start variable, stop expresion, after loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            // forEach is also an iteration loop
            var weekDays = new string[] {"monday", "tuesday", "wednesday", "thursday", "friday" };
            foreach (var weekDay in weekDays)
            {
                Console.WriteLine(weekDay);
            }

            // parse converts a string to a non-string 
            var intFromString = int.Parse("123");
            Console.WriteLine(intFromString + 123);

            // tryParse is the same as parse but will not throw if it fails
            // instead it will return a bool of true if it was successful and false if it failed
            var success = int.TryParse("Soup", out var myInt);
            if (success)
            {
                Console.WriteLine(myInt + 1000);
            }
            else
            {
                Console.WriteLine("parse failed");
            }
        }
    }
}
