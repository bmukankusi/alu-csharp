namespace Enemies {
    /// <summary>
    /// This is a Class representation of a zombie.
    /// </summary>
    class Zombie {
        private int health;

        /// <summary>
        /// This is a constructor that sets the health to 0.
        /// </summary>

        public Zombie() {
            health = 0;
        }

        ///<summary>
        /// This is a paramaterized constructor which gives health a value
        /// </summary>

        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        ///<summary>
        /// This is a method which returns the health of a zombie
        /// </summary>

        public int GetHealth() {
            return health;
        }

    }

    class Program {
        static void Main(string[] args) {
            // Example usage
            Zombie zombie = new Zombie(5);
            Console.WriteLine("A new zombie has been created.");
            Console.WriteLine("The zombie has " + zombie.GetHealth() + " health.");
        }
    }
}