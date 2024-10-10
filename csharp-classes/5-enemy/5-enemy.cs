using System.Reflection.Metadata.Ecma335;

namespace Enemies {
    /// <summary>
    /// This is a Class representation of a zombie.
    /// </summary>
    class Zombie {
        private int health;
        private string name;

        /// <summary>
        /// This is a constructor that sets the health to 0.
        /// </summary>

        public Zombie() {
            health = 0;
            name = "(No name)";
        }

        ///<summary>
        /// This is a paramaterized constructor which gives health a value.
        /// </summary>

        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
            name = "(No name)";
        }
        ///<summary>
        /// This is a method which returns the health of a zombie.
        /// </summary>

        public int GetHealth() {
            return health;
        }

        public string Name {
            get {return name;}
            set {name =  value;}
        }

        ///<summary>
        /// This is a method which overrides the ToString method.
        /// </summary>

        override public string ToString() {
            return $"Zombie Name: {Name} / Total Health: {health}";
        }

    }

    class Program {
        static void Main(string[] args) {
            // Example usage, builds a new zombie and prints its health
            Zombie zombie = new Zombie(5);
            Console.WriteLine("A new zombie has been created.");
            Console.WriteLine("The zombie has " + zombie.GetHealth() + " health.");
            Console.WriteLine("The zombie's name is " + zombie.Name);
            zombie.Name = "Bob";
            Console.WriteLine("The zombie's name is now " + zombie.Name);
            Console.WriteLine(zombie.ToString());
        }
    }
}