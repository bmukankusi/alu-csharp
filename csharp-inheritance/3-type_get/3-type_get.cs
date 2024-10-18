using System;
using System.Reflection;

namespace methods
{
    /// <summary>
    /// Provides methods for inspecting objects.
    /// </summary>
    public static class Obj
    {
        /// <summary>
        /// Prints the names of the available properties and methods of an object.
        /// </summary>
        /// <param name="myObj">The object to inspect.</param>
        public static void Print(object myObj)
        {
            if (myObj == null)
            {
                Console.WriteLine("Object is null");
                return;
            }

            Type type = myObj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            MethodInfo[] methods = type.GetMethods();

            Console.WriteLine($"{type.Name} Properties:");
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine($"{type.Name} Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }

    //example class
       class Program
    {
       static void Main(string[] args)
        {
          var number = 10;
          var myList = new List<int>();

          Obj.Print(number);
          Console.WriteLine("---------------");
          Obj.Print(myList);
        }
    }
}