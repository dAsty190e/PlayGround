namespace Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display catalog of items
            // create your own item
            // inheritance, abstraction, OOP, classes, methods

            var userInput = string.Empty;


            var test = new TestCatalog();
            Console.WriteLine(test.CompanyName);

            Console.WriteLine($"Hello! Welcome to {test.CompanyName}");
            Console.WriteLine($"This catalog was published on: {test.PublishDate}");
            Console.WriteLine($"Advertisement: {test.Advertisement}");

            
            do
            {

                foreach (var item in test.CatalogItems)
                {
                    Console.WriteLine($"\t{item.Title} - #{item.Id}");
                    Console.WriteLine($"{item.Description}, \n{item.Price}, \n{item.Quantity}");
                }

                var valid = false;
                var selectedItem = 0;
                do
                {
                    Console.WriteLine("What would you like to buy?");
                    // accept user input
                    userInput = Console.ReadLine();
                    // validate user input
                    if (int.TryParse(userInput, out var validNumber))
                    {
                        // check if user input is a number
                        if (test.CatalogItems.Any(item => item.Id == validNumber)) // --> lambda - in-line method
                        {
                            // found a match
                            // valid
                            valid = true;
                            selectedItem = validNumber;
                        }
                        else
                        {
                            // no match found 
                            Console.WriteLine("Sorry it is a wrong item number. Try again.");
                        }
                    }
                    else
                    {
                        // not a number
                        Console.WriteLine("Sorry it is not a number. Try again.");
                    }
                } while (!valid);

                // ask how many items do they want
                Console.WriteLine("How many do you want?");
                // accept user input
                userInput = Console.ReadLine();
                // validate user input
                // check if its number
                if (int.TryParse(userInput, out var validNumber2))
                {
                    // get the item
                    var categoryItem = test.CatalogItems.FirstOrDefault(item => item.Id == selectedItem);
                    // do we have enough of the items?
                    if (categoryItem.Quantity >= validNumber2)
                    {
                        // sell
                        Console.WriteLine($"You get: {userInput} {categoryItem.Title}");
                        categoryItem.Quantity -= validNumber2;
                        Console.WriteLine($"");
                    }
                    else
                    {
                        // not enough in storage
                        Console.WriteLine("Sorry we do not have enough.");
                    }
                }

            } while (true);


        }
    }
}