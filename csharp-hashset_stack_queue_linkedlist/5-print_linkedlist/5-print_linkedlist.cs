using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLList;

        if(size >= 0) 
            newLList = new LinkedList<int>(Enumerable.Range(0, size).ToList());
        else 
            newLList = new LinkedList<int>();
        
        foreach (int element in newLList) Console.WriteLine($"{element}");

        return newLList;
    }
}
