namespace _013_Picachu
{
    internal class PiperCat
    {
        private int _baseDamage = 15;


        public int AbilityPoints { get; set; } = 50;
        public int HealthPoints { get; set; } = 150;
        public string Name { get; } = "Piper";
        public string Color { get; } = "White";
        public int Legs { get; private set; } = 4;
        public bool HasTail { get { return HealthPoints > 100; } }
        public int Meow()
        {
            AbilityPoints -= 12;
            if (AbilityPoints < 0)
            {
                AbilityPoints += 12;
                return _baseDamage;
            }
            return _baseDamage + 15;
        }
        public int Nap()
        {
            AbilityPoints += 30;
            return 0;
        }
        public int TailSwipe()
        {
            if (HasTail)
            {
                return new Random().Next(20);
            }
            return Nap();
        }

        public int Attack()
        {
            return _baseDamage;
        }
    }
}
