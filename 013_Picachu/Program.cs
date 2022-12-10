namespace _013_Picachu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Picachu("Joe");
            var player2 = new PiperCat();

            bool noWinner = true;
            var winnerName = string.Empty;
            do
            {
                Console.WriteLine($"{player1.Name}: its your turn");
                Console.WriteLine("What will you do? \n 1.Attack \n 2.Lightning Bolt \n 3.Lightning Ball");
                var action1 = Console.ReadKey(true).KeyChar;
                Console.Clear();
                var damage = 0;
                switch (action1)
                {
                    case '1':
                        damage = player1.Attack();
                        break;
                    case '2':
                        damage = player1.LightningBolt();
                        break;
                    case '3':
                        damage = player1.LightningBall();
                        break;

                    default:
                        break;
                }
                player2.HealthPoints -= damage;
                Console.WriteLine($"{player2.Name} takes {damage} damage. {player2.Name} has {player2.HealthPoints} HP remaining. {player1.Name} has {player1.AbilityPoints} AP left");

                if (player2.HealthPoints < 0)
                { 
                    noWinner = false;
                    winnerName = player1.Name;
                }

                Console.WriteLine($"{player2.Name}: its your turn");
                Console.WriteLine("What will you do? \n 1.Attack \n 2.Meow \n 3.Nap \n 4.Tail Swipe");
                var action2 = Console.ReadKey(true).KeyChar;
                Console.Clear();
                var damage2 = 0;
                switch (action2)
                {
                    case '1':
                        damage2 = player2.Attack();
                        break;
                    case '2':
                        damage2 = player2.Meow();
                        break;
                    case '3':
                        damage2 = player2.Nap();
                        break;
                    case '4':
                        damage2 = player2.TailSwipe();
                        break;
                    default:
                        break;
                }
                player1.HealthPoints -= damage2;
                Console.WriteLine($"{player1.Name} takes {damage2} damage. {player1.Name} has {player1.HealthPoints} HP remaining. {player2.Name} has {player2.AbilityPoints} AP left");
                
                if (player1.HealthPoints < 0)
                {
                    noWinner = false;
                    winnerName = player2.Name;
                }
            } while (noWinner);
            Console.Beep();
            Console.WriteLine($"{winnerName} is victorious!");
            Console.Beep();
        }
    }
}