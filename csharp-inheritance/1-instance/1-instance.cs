namespace _1_instance
{
    /// <summary>
    /// Provides methods for type checking.
    /// </summary>
    public static class Obj
    {
        /// <summary>
        /// Determines whether the specified object is an instance of Array or a class that inherited from Array.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>True if the object is an instance of Array or a class that inherited from Array, otherwise False.</returns>
        public static bool IsInstanceOfArray(object obj)
        {
            return obj is Array;
        }
    }
}