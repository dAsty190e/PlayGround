namespace _013_Picachu
{
    internal class Picachu
    {
        // fields (private state)
        private int _baseDamage = 10; 
        // constructors
        public Picachu(string name)
        {
            Name = name;
        }
        public Picachu(string name, int level)
        {
            Name = name;
            Level = level;
        }
        // properties
        public int HealthPoints { get; set; } = 100;
        public int AbilityPoints { get;private set; } = 20;
        public string Name { get; set; }
        // public int BaseDamage { get; set; } = 10;
        public int Level { get; private set; } = 1;
        // methods
        public int Attack()
        {
            return _baseDamage;
        }
        public int LightningBall()
        {
            AbilityPoints -= 10;
            if (CantExecute())
            {
                AbilityPoints += 10;
                return _baseDamage;
            }
            return _baseDamage + 10;
        }
        public int LightningBolt()
        {
            AbilityPoints -= 5;
            if (CantExecute())
            {
                AbilityPoints += 5;
                return _baseDamage;
            }
            return _baseDamage + 7;
        }
        // Helper method
        private bool CantExecute() 
        {
            return AbilityPoints < 0;  
        }
    }
}
