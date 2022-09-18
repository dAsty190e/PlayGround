using System;

namespace _04_Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();

            Console.WriteLine("The fishing game");

            //bool success = false;

            Console.WriteLine("\nWould you like to go fishing? y/n");
            var fish = Console.ReadKey().KeyChar; // or --- char fish --- 

            if (char.ToLower(fish) == 'y')
            {
                var control = true;
                do
                {
                    Console.WriteLine("\nWhich lure to use? a/b/c");
                    Console.WriteLine("\na.Metal Lure");
                    Console.WriteLine("\nb.Spiner Lure");
                    Console.WriteLine("\nc.Wood Lure");
                    string lure = Console.ReadLine();
                    lure = lure.ToLower();

                    if (lure == "a")
                    {
                        Console.WriteLine("\nMetal Lure");
                    }
                    else if (lure == "b")
                    {
                        Console.WriteLine("\nSpiner Lure");
                    }
                    else if (lure == "c")
                    {
                        Console.WriteLine("\nWood Lure");
                    }

                    Console.WriteLine("\nWhich bait to use? a/b/c");
                    Console.WriteLine("\na.Sand Leach");
                    Console.WriteLine("\nb.Verstate lure");
                    Console.WriteLine("\nc.Shrimp bascket");
                    string bait = Console.ReadLine(); // string can be in one line - string bite = Console.Readline().ToLover());
                    bait = bait.ToLower(); // if string is in one line - this line can be removed

                    if (bait == "a")
                    {
                        Console.WriteLine("\nSand leach");
                    }
                    else if (bait == "b")
                    {
                        Console.WriteLine("\nVerstate lure");
                    }
                    else if (bait == "c")
                    {
                        Console.WriteLine("\nShrimp bascket");
                    }

                    Console.WriteLine("\nWhich time of day to go fishing? a/b/c");
                    Console.WriteLine("\na.Morning");
                    Console.WriteLine("\nb.Afternoon");
                    Console.WriteLine("\nc.Evening");
                    string time = Console.ReadLine();
                    time = time.ToLower();

                    if (time == "a")
                    {
                        Console.WriteLine("\nMorning");
                    }
                    else if (time == "b")
                    {
                        Console.WriteLine("\nAfternoon");
                    }
                    else if (time == "c")
                    {
                        Console.WriteLine("\nEvening");
                    }

                    Console.WriteLine("\nDid you want to start? y/n");
                    string start = Console.ReadLine();
                    start = start.ToLower();

                    if (start == "y")
                    {
                        Console.WriteLine("\nGood luck!");
                        int pounds = rng.Next(0, 100);
                        Console.WriteLine($"\nYou catch a fish! It weighs {pounds} pounds");
                        Console.WriteLine("\nDo you want try again?");
                        string again = Console.ReadLine();
                        again = again.ToLower();

                        if (again == "y")
                        {
                            Console.WriteLine("\nLets do it!");
                        }
                        else if (again == "n")
                        {
                            Console.WriteLine("\nSee you later!");
                            control = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n");
                    }
                } while (control);
                

            }
            else if (char.ToLower(fish) == 'n')
            {
                Console.WriteLine("\nMayby later");
            }
        }
    }
}
