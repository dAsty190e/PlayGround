namespace _010_ExerciseAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            var question1 = new Question
            {
                Text = "What is the variable?",
                Answers = new string[] 
                {
                    "a block of memory that contains a value", 
                    "a collection",
                    "an expression"
                } 
            };

            Console.WriteLine(question1.Text);

            for (int i = 0; i < question1.Answers.Length; i++)
            {
                var ex = i + 1;
                string? answer = question1.Answers[i];
                Console.WriteLine("\t" + ex + ". " + answer);
                //Console.WriteLine("\t" + (i+1) + ". " + answer);  ---and we not create a variable- var ex = i + 1;
                //Console.WriteLine("\t" + (i+1) + ". " + question1.Answers[i]); ---to not create a variable-  string? answer = question1.Answers[i];
            }
            var userAnswer = Console.ReadKey().KeyChar;
            if (userAnswer == '1')
            {
                question1.Correct = true;
            }
            Console.WriteLine();

            //Q2
            var question2 = new Question
            {
                Text ="What is a Type?",
                Answers = new string[]
                {
                    "collection of classes",
                    "type is a type",
                    "a definition of something"
                }
                
            };
            
            Console.WriteLine(question2.Text);

            for (int i = 0; i < question2.Answers.Length; i++)
            {
                var myx = i + 1;
                string answer = question2.Answers[i];
                Console.WriteLine("\t" + myx + ". " + answer);
            }
            var userAnswer2 = Console.ReadKey().KeyChar;
            if (userAnswer2 == '3')
            {
                question2.Correct = true;
            }
            Console.WriteLine();

            //Q3
            var question3 = new Question
            {
                Text = "What is an Array?",
                Answers = new string[]
                {
                    "it is an iteration loop",
                    "it is a collection of values",
                    "it is a method that returns a new string"
                }

            };
            Console.WriteLine(question3.Text);

            for (int i = 0; i < question3.Answers.Length; i++)
            {
                var vox = i + 1;
                string answer = question3.Answers[i];
                Console.WriteLine("\t" + vox + ". " + answer);
            }
            var userAnswer3 = Console.ReadKey().KeyChar;
            if (userAnswer3 == '2')
            {
                question3.Correct = true;
            }
            Console.WriteLine();
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Answers { get; set; }
        public bool Correct { get; set; }
    }
}