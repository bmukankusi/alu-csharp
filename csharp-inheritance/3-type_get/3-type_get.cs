using System;
using System.Reflection;

namespace YourNamespace
{
    /// <summary>
    /// Represents the class Obj.
    /// </summary>
    public class Obj
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the Obj class.
        /// </summary>
        public Obj()
        {
            name = string.Empty; // Initialize the non-nullable field
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Prints the names of the available properties and methods of an object.
        /// </summary>
        /// <param name="myObj">Object from where to get information.</param>
        public static void Print(object myObj)
        {
            Type type = myObj.GetType();

            Console.WriteLine($"{type.Name} Properties:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }

            Console.WriteLine($"{type.Name} Methods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}