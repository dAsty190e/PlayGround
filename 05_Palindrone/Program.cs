using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Palindrone
{
    class Program
    {
        /// <summary>
        /// Areas of focus: comparison, iteration, variables
        /// Secondary: reverse iteration
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\nGive me a word and I will tell you if its a palindrone!");
            var word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++) // for loop (iteration) 
            {
                Console.WriteLine( word[i]);
            }

            //reverse for loop
            var stringReversed = "";
            for (int i = word.Length - 1; i >= 0 ; i--) // iteration
            {
                stringReversed = stringReversed + word[i]; // stringReversed += word[i];   (variebles)
                //Console.WriteLine(word[i]);
            }
            Console.WriteLine(stringReversed);
            Console.WriteLine(word == stringReversed); // comparisom oparation
        }
    }
}
