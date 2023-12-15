using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach (KeyValuePair<string, int> element in myDict)
            myDict[element.Key] = element.Value * 2;

        return myDict;
    }
}
