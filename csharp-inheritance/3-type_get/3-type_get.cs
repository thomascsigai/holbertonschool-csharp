using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

///<summary> Defines objects tools methods implementations.</summary>
class Obj
{
    ///<summary>Prints the names of the available properties and methods of an object.</summary>
    ///<param name="myObj">The subclass.</param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }
        
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (MethodInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}
