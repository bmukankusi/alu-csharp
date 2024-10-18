using System;
/// <summary>
/// An instance of a class inherits from another class.
/// </summary>

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return(true);
        else
            return(false);
    }
}