using System;
using System.Reflection;

///<summary> Defines objects tools methods implementations.</summary>
class Obj
{
    ///<summary>Tells if the object is an instance of a class that inherits from the specified class.</summary>
    ///<param name="derivedType">The subclass.</param>
    ///<param name="baseType">The base class.</param>
    ///<returns>True if the object is an instance of a class that inherits from the specified class, otherwise return False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
