using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            float f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0;

            Console.WriteLine($"f1 is {f1}, f2 is {f2}, f3 is {f3}");
            f1 = f1 + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f;
            Console.WriteLine($"f1 = (0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1)? = {f1}");

            // post increment and decrement operators
            /*var age = 0;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            */

            // pre increment (++ front)
            var year = 2022;
            var year2 = ++year;
            var year3 = year;
            Console.WriteLine(year2);
            Console.WriteLine(year3);

            // post increment (after ++)
            var month = 2022;
            var month2 = month++;
            var month3 = month;
            Console.WriteLine(month2);
            Console.WriteLine(month3);

            int n1 = 0;
            {
                int n2 = 7;
                int n3 = 11;
                int n4 = n1 + n2 + n3;
                {
                    int n5 = 10 + n1; 
                }
                //n4 + n5; - cant find n5
            }
        }
    }
}
