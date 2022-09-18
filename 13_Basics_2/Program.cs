using System;

namespace _13_Basics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var startOver = false;

            do
            {

                int num1 = 10;
                int num2 = num1 + 10;

                Console.WriteLine(num2);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(num2 + i);
                }

                var outPut = $"num2 is {num2} " + "hello world";
                Console.WriteLine(outPut);
                // Console.WriteLine($"num2 is {num2} " + "hello world");

                Console.WriteLine(outPut + " bye bye");
                Console.WriteLine(outPut);


                Console.WriteLine("Zack said \"I love you\"");

                Console.WriteLine("Give me a number - 1, 2");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Hello world!");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Hello Piper Cat!");
                }
                else Console.WriteLine("Brrrrr!");

                Console.WriteLine("Give me another number and I will multiply it by 10");
                var multy = Console.ReadLine();
                int mParst = int.Parse(multy);
                Console.WriteLine(mParst * 10);


                // WHILE LOOP
                Console.WriteLine("Pick a number between 1 and 10");
                string inP = Console.ReadLine();
                int inM = int.Parse(inP);
                int x = 8;

                while (inM != x)
                {
                    Console.WriteLine("Try again!");
                    inP = Console.ReadLine();
                    inM = int.Parse(inP);
                    //  x = inM + 1; - we can treack user - it will always be  +1
                }

                Console.WriteLine("Start over? y/n");
                var correct = Console.ReadKey().KeyChar;

                if (correct == 'y')
                {
                    Console.WriteLine("OK!");
                    startOver = true;
                }
                else 
                {
                    Console.WriteLine("bye bye!");
                    startOver = false;
                }


            } while (startOver);

        }
    }
}
