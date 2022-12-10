namespace _2._3._3_YB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the WindowWidth
            /*Console.WindowWidth = 130;

            Console.WindowHeight = 30;

            // Get the WindowWidth
            Console.WriteLine("Current WindowWidth: {0}",
                                    Console.WindowWidth);
            // Get the WindowWidth
            Console.Write("Current WindowWidth: {0}",
                                Console.WindowHeight);*/

            // NEXT CHAPTER

            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthString, heightString;

            Console.Write("Give the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n" );
                Console.WriteLine("Using minimum" );
                width = MIN_WIDTH;
            }

            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large.\n\n" );
                Console.WriteLine("Using maximum" );
                width = MAX_WIDTH;
            }

            Console.Write("Give the height of the window : " );
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n" );
                Console.WriteLine("Using minimum" );
                height = MIN_HEIGHT;
            }

            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n" );
                Console.WriteLine("Using maximum");
                height = MAX_HEIGHT;
            }

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width + height);

            Console.WriteLine("The length of the wood is " + woodLength + "feet" );
            Console.WriteLine("The area of the glass is " + glassArea + "square meters" );

        }
    }
}