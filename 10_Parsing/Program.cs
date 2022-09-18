using System;

namespace _10_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse takes a string and convert it to a non-string
            Console.WriteLine("Give me a number!");
            var userNumber = Console.ReadLine();
            var x = int.Parse(userNumber);
            Console.WriteLine(x *10);

            Console.WriteLine("Give me another munber");
            userNumber = Console.ReadLine();
            var success = int.TryParse(userNumber, out var newInt);
            if (success)
            {
                Console.WriteLine(newInt *100);
            }
            else Console.WriteLine(userNumber + " Is not an Int");

        }
    }
}
