namespace _011_Length_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Counting Char in sentence - .Length
            string bat = "Piper cat want go to pet shop"; // (29 char)
            Console.WriteLine(bat.Length);
            Console.WriteLine($"{bat}: " + "You have: " + bat.Length + " characters in this sentence");

            //found index of number  - .IndexOf("")
            string mana = "12345678890";
            Console.WriteLine(mana.IndexOf("5")); //(index 2)
            Console.WriteLine($"{mana}: " + "your index from 5 is - " + mana.IndexOf("5"));

            //method to concatenate two strings - string.Concat()
            string firstName = "Kate ";
            string secondName = "Walker";
            string fullName = string.Concat(firstName, secondName);
            Console.WriteLine(fullName);
            //or 
            string herName = firstName + secondName;
            Console.WriteLine(herName);
            //string interpolation ($"{}")
            string thisName = $"{firstName}{secondName}";
            Console.WriteLine(thisName + " - string interpolation");
            Console.WriteLine($"{firstName}{secondName}" + "if in Console.WriteLine");
            //print the last or first name
            string kateName = "Kate Walker";
            int findChar = kateName.IndexOf("W");
            string kateLast = kateName.Substring(findChar);
            Console.WriteLine(kateLast);

            List





            // prints the first character in myString[]
            string pet = "PiperCat";
            Console.WriteLine(pet[5]);
            Console.WriteLine($"what: " + pet[5]);
            Console.WriteLine($"index of e: " + pet.IndexOf("e"));
        }
    }
}