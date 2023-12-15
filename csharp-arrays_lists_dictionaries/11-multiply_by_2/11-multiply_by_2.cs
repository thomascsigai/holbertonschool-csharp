using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> element in myDict.ToList())
            newDict[element.Key] = element.Value * 2;

        return newDict;
    }
}
