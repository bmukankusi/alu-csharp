using System;

namespace MyNamespace
{
    /// <summary>
    /// Provides methods for type checking.
    /// </summary>
    public static class Obj
    {
        /// <summary>
        /// Determines whether the specified object is an instance of a class that inherits from the specified base class.
        /// </summary>
        /// <param name="derivedType">The type of the object to check.</param>
        /// <param name="baseType">The base class type.</param>
        /// <returns>True if the object is an instance of a class that inherits from the specified base class, otherwise False.</returns>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            if (derivedType.IsSubclassOf(baseType))
            {
                return true;
        }
        return false;
    }
}