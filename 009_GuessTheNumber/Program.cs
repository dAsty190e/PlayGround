// See https://aka.ms/new-console-template for more information

string userInput;
int number;
var gameGuess = true;
var random = new Random();
var guessNumber = random.Next(1, 100);


Console.WriteLine("Guess the Number 1-100");
do
{
    userInput = Console.ReadLine()!;
    var parseTo = int.TryParse(userInput, out number);
    while (!parseTo)
    {
        Console.WriteLine($"Sorry, {userInput} need include numbers!");
        Console.WriteLine("Guess the Number 1-100");
        userInput = Console.ReadLine()!;
        parseTo = int.TryParse(userInput, out number);
    }
    if (number > guessNumber)
    {
        Console.WriteLine("Too high");
    }
    else if (number < guessNumber)
    {
        Console.WriteLine("Too low");
    }
    else
    {
        Console.WriteLine("Correct");
        Console.WriteLine("\nDo you want try again? Press Y to try again or press any other key to exit");
        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        ConsoleKey tryAgain = consoleKeyInfo.Key;

        if (tryAgain == ConsoleKey.Y)
        {
            gameGuess = true;
            Console.WriteLine("\nGuess the Number 1-100");
            guessNumber = random.Next(1, 100);

        }
        else 
        {
            Console.WriteLine("\nSee you!");
            gameGuess = false;
        }
    }
} while (gameGuess);
