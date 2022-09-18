using System;
using System.Collections.Generic;

namespace _06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays are fixed
            var animals = new string[] { "cat", "dog", "bird" }; // "cat" = 0; "dog" = 1; "bird" = 2;
            // Lists are flexible 
            var food = new List<string> { "carrot", "potato", "cabage" };
            // var dog = animals[1]; - this will copy "dog" in my variable


            // iteration
            int y = 0;
            do
            {
                Console.WriteLine($"{animals[y]} {y}");
                y++;
            } while (y < animals.Length);

            //   start;   end/terminator; increment
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($" { animals[i] } { i } ");
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            /*foreach (var blabla in food)
            {
                Console.WriteLine(blabla);
            }*/

            //add to List items
            food.Add("apple");
            food.Add("beans");
            foreach (var gross in food)
            {
                Console.WriteLine(gross);
            }

            food.AddRange(new string[] { "milk", "water", "garlick" }); // AddRange - add many. (its requires another collection (ienumerable)) 
            food.Sort();
            foreach (var gross in food)
            {
                Console.WriteLine(gross);
            }
        }
    }
}
