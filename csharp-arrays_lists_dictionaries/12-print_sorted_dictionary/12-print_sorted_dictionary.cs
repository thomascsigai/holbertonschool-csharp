using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> newSortedList = new SortedList<string, string>();

        foreach (KeyValuePair<string, string> element in myDict)
            newSortedList.Add(element.Key, element.Value);

        foreach (KeyValuePair<string, string> element in newSortedList)
            Console.WriteLine("{0}: {1}", element.Key, element.Value);
    }
}
