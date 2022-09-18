using System;

namespace _14_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = true;
            do
            {
                Console.WriteLine("Give me a word and I will count vowels");
                string word = Console.ReadLine();
                int aCount, eCount, iCount, oCount, uCount;
                aCount = eCount = iCount = oCount = uCount = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    var letter = word[i];
                    if (char.ToLower(letter) == 'a') 
                    {
                        aCount++; 
                    }
                    if (char.ToLower(letter) == 'e')
                    {
                        eCount++;
                    }
                    if (char.ToLower(letter) == 'i')
                    {
                        iCount++;
                    }
                    if (char.ToLower(letter) == 'o')
                    {
                        oCount++;
                    }
                    if (char.ToLower(letter) == 'u')
                    {
                        uCount++;
                    }
                }
                Console.WriteLine("a:" + aCount + " e:" + eCount + " i:" + iCount + " o:" + oCount + " u:" + uCount);
                Console.WriteLine("\nStart over? y/n");
                var key = Console.ReadKey();
                char bChar = key.KeyChar;
                char bCharLover = char.ToLower(bChar);
                cont = bCharLover == 'y';

                // short way to do: 
                cont = key.Key == ConsoleKey.Y;
                

            } while (cont);
        }
    }
}
