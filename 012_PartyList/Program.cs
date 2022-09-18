namespace _012_PartyList
{
    /* I have to make a C# program with a list for a party. An example of the list is: John, brownies, 5, Kevin, cookies, 4, Ann, wings, 6.
    After making that list, how would I answer questions such as how many people can be fed if John cancels? and what type of foods will there be?
    Im not sure how I would create a list with both strings and numbers and then answer those questions so any help would be appreciated. Thank you! */

    internal class Program
    {
        static void Main(string[] args)
        {
            var guest = new PartyMember[]
            {
                new PartyMember
                {
                    Name = "John",
                    Food = "brownies",
                    Count = 5
                },

                new PartyMember 
                {
                    Name = "Kevin",
                    Food = "cookies",
                    Count = 4
                },

                new PartyMember 
                {
                    Name = "Ann",
                    Food = "wings",
                    Count = 6
                }
            };

            var total = 0;
            foreach (var member in guest) 
            {
               // total += member.Count;
                Console.WriteLine(member.Count);

                if (member.Name != "Kevin") // (member.Name == "Kevin")
                {
                    total += member.Count; // total -= member.Count;
                }
            }
            Console.WriteLine(total);
        }
    }

    class PartyMember 
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int Count { get; set; }
    }
}