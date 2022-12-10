namespace _2._2._10_YB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double woodLength;
            // double glassArea;
            Console.WriteLine("Add Length of the wood: ");
            string widthString = Console.ReadLine();
            double width = double.Parse(widthString);

            Console.WriteLine("Add area of the glass: ");
            string heightString = Console.ReadLine();
            int height = int.Parse(heightString);

            var woodLength = 2 * (width + height) * 3.25;

            var glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine();


            // NEXT

            int tabletCount;
            int pricePerBottle;

            Console.WriteLine("Write price for bottle");
            string priceBottleString = Console.ReadLine();
            pricePerBottle = int.Parse(priceBottleString);

            Console.WriteLine("Write table Count");
            string tabletCountString = Console.ReadLine();
            tabletCount = int.Parse(tabletCountString);

            int bottleCount = ((tabletCount + 99) / 100);
            int salePrice = bottleCount * pricePerBottle;

            Console.WriteLine("The number of bottles is " + bottleCount);
            Console.WriteLine("The total price is " + salePrice);


        }
    }
}