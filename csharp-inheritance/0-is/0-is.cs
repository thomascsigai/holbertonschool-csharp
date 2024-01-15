using System;

///<summary> Defines objects tools methods implementations.</summary>
class Obj
{
    ///<summary>Tells if an object is type of int.</summary>
    ///<param name="obj">The object to check</param>
    ///<returns>True if the object is an int, otherwise return False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
