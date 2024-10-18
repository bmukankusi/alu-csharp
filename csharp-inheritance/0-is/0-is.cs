

namespace Object
{
    /// <summary>
    /// Provides methods for type checking.
    /// </summary>
    public static class Obj
    {
        /// <summary>
        /// Determines whether the specified object is of type int.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>True if the object is of type int, otherwise False.</returns>
        public static bool IsOfTypeInt(object obj)
        {
           if (obj is int)
              {
                    return true;
              }
        return false;
    }
}