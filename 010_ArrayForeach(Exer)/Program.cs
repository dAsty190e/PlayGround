namespace _010_ArrayForeach_Exer_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var books = new Book[]
            {
                new Book
                {
                    Name = "Lara Croft and her book of C#",
                    Genre = "Fantasy",
                    PageCount = 300,
                    ReleaseDate = new DateTime(2022, 11, 17),
                    Author = new Author
                    {
                        FirstName = "Gigi",
                        LastName = "Oggo"
                    }
                },
                new Book
                {
                    Name = "Harry Potter and his Cat",
                    Genre = "Fantasy",
                    PageCount = 300,
                    ReleaseDate = new DateTime(2023, 12, 18),
                    Author = new Author
                    {
                        FirstName = "Rita",
                        LastName = "Boo"
                    }
                },
                new Book
                {
                    Name = "Piper Piglet and her dirty butt",
                    Genre = "Jokes",
                    PageCount = 500,
                    Author = new Author
                    {
                        FirstName = "Zach",
                        LastName = "Jones"
                    }
                }
            };

            /* foreach (var book in books)
             {
                 Console.WriteLine();

                 Console.WriteLine("This book not about a boy, this book about his cat");
                 Console.WriteLine($"{book.Name} will be released in {book.ReleaseDate}");
                 Console.WriteLine($"It is {book.Genre} and it has {book.PageCount}");
             //  Console.WriteLine($"And it written by {book.Author.FirstName} {book.Author.LastName}");
                 Console.WriteLine($"And it written by {book.Author.FullName()}");
             }*/

            foreach (var book in books)
            {
                book.Print(); 
            }

        }
    }

    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName() 
        {
            return FirstName + " " + LastName;
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public void Print() 
        {
            Console.WriteLine();

            Console.WriteLine("This book not about a boy, this book about his cat");
            Console.WriteLine($"{Name} will be released in {ReleaseDate}");
            Console.WriteLine($"It is {Genre} and it has {PageCount}");
            //  Console.WriteLine($"And it written by {book.Author.FirstName} {book.Author.LastName}");
            Console.WriteLine($"And it written by {Author.FullName()}");
        }
    }
}