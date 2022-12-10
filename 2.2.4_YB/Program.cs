namespace _2._2._4_YB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unicodes

            char beep = '\a'; 
            Console.WriteLine($"{beep}"); //make a beep noise

            char letterA = '\x0041';
            Console.WriteLine($"{letterA}"); // unicode for letter A

            char emojiSmile = '\u263A';
            Console.WriteLine($"{emojiSmile}"); // unicide for emoji - smile face

            string escapeSeqForA = "\x0041BCDE\a";
            Console.WriteLine($"{escapeSeqForA}"); // unicode A + letters BCDE

            string escape = @"\x0041BCDE\a";
            Console.WriteLine($"{escape}"); // unicode A + letters BCDE  -- will print whole line "\x0041BCDE\a"

            string fox = @"The quick brown fox jumps over the lazy dog";
            Console.WriteLine($"{fox}");  // ????????

            // operands and operators

            int first, second, third;
            first = 1;
            second = 2;
            third = second + first;
            Console.WriteLine($"{third}");

            int one, two, three, four;
            one = 2+3*4;
            two = -1+3;
            three = (2 + 3) * 4;
            four = one + two + three;
            Console.WriteLine($"{four}");

            // Changing the Type of Data
            // 1 - Widening and Narrowing

            int i = 1;
            float x = i;
            Console.WriteLine($"{x}"); // its working because the floating-type can hold the value supported bu the integer type.

            /* 
            float a = 1;
            int b = a;
            Console.WriteLine($"{b}"); // (it will be treated like an error)
            */

            /*
            double d = 1.5;
            float f = d;
            Console.WriteLine($"{f}"); // double is wider than a float (it will be treated like an error) 
            */
        }
    }
}