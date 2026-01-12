namespace OOPCharacter12B26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character(100);
            player1.changeHealth(-50);
            Console.WriteLine(player1.getHealth());

        }
    }
    class Character
    {
        // add properties for name, level, gold, armour
        private int health;  // private can't access outside of the class by the object directly

        // add methods to get and set level, health, armour and gold
        // add name to the constructor
        public Character(int startHealth) // Instantiation - To be explained later (Called with new)
        {
            health = startHealth;
        }
        public void changeHealth(int change)// public allows to be called by the object created
        {
            health += change;
            if (health > 100)
            {
                health = 100;
            }
        }
        public int getHealth()
        {
            return health; 
        }
    }

}
