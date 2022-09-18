using System;
using System.Collections.Generic;

namespace _004_CollectablesArray_Training_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month");
            var calendarMonth = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < calendarMonth.Length; i++)
            {
                Console.WriteLine($"{i}. {calendarMonth[i]}");
            }

            Console.WriteLine("Time");
            var dayTime = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            for (int i = dayTime.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i}. {dayTime[i]}");
            }

            string userP;
            Console.WriteLine("List");
            List<string> shoingList = new List<string> { "Carrot", "Potato", "Eggs" };
            do
            {
                shoingList.Sort();
                foreach (var item in shoingList)
                {
                    Console.WriteLine($"{item}");
                }

                Console.WriteLine("Wold you like to add new item to the List? (no | item)");
                userP = Console.ReadLine();

                if (userP.ToLower() == "no")
                {
                    Console.WriteLine("Thanks for shoping");
                }
                else 
                {
                    shoingList.Add(userP);
                }
            } while (userP.ToLower() != "no");

            Console.WriteLine("Calendar");
            var calendar = new List<string> { "January", "February", "March", "April", "May", "June" };
            calendar.AddRange(new List<string> { "July", "August", "September", "October", "November", "December" });

            calendar.Reverse();

            foreach (var item in calendar)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}
