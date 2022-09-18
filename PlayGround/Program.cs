// Other namespaces
using System;

// namespace is a way to organize code (classes and methods)
// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces
namespace PlayGround
{
    // class Program and the static void main method is the starting point for all .Net Programs
    class Program
    {
        static void Main(string[] args)
        {
            // the Console - is a text based user interface
            // .WriteLine (cw tab tab) will output text and start a new line
            Console.WriteLine("Hello World!");
            Console.WriteLine("Piper Cat - Fat Cat");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How is your day?");
            var Kitty = Console.ReadLine();
            Console.WriteLine(Kitty + " meow meow <3");

            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

            // explicitly declared variable
            bool isTrue = true;
            // implicitly declared variable
            var isFalse = false;
            int myNumber = 999999;
            var otherNumber = 888888;
            char letter = 'l';
            string myName = "Piper";
            double pi = 3.14;

            // Declaration only:
            float temperature;
            string name;

            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;

            int myVar;
            myVar = 25;
            myVar = 2;
            Console.WriteLine(myVar);
            // TODO: understand the difference between value type and reference type 
            // Heap vs stack    


        }
    }
}
