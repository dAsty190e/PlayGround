using System;

namespace _07_NextLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.WriteLine("Give me a letter and I give the next letter back!");


            var letter = Console.ReadKey().KeyChar;
            var newArayIndex = Array.IndexOf(alphabet, letter);
            Console.WriteLine(alphabet[newArayIndex +1]);

            
        }
    }
}
