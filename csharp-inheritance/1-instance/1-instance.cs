using System;

///<summary> Defines objects tools methods implementations.</summary>
class Obj
{
    ///<summary>if the object is an instance of, or if the object is an instance of a class that inherited from, Array.</summary>
    ///<param name="obj">The object to check</param>
    ///<returns>True if the object is an Array, otherwise return False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
