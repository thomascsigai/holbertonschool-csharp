using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLList = new LinkedList<int>(Enumerable.Range(0, size).ToList());
        foreach (int element in newLList) Console.WriteLine($"{element}");

        return newLList;
    }
}
