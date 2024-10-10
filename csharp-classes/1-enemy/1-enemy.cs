﻿﻿namespace Enemies {
    /// <summary>
    /// This is a Class representation of a zombie
    /// </summary>
    class Zombie {
        public int health;

        /// <summary>
        /// This is a constructor that sets the health to 0.
        /// </summary>

        public Zombie() {
            health = 0;
        }
    }

    class Program {
        static void Main(string[] args) {
            // Example usage
            Zombie zombie = new Zombie();
            Console.WriteLine("A new zombie has been created.");
            Console.WriteLine("The zombie has " + zombie.health + " health.");
        }
    }
}