using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int maxValue;

        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        maxValue = myList[0];

        foreach (int element in myList)
            if (element > maxValue)
                maxValue = element;
                
        return maxValue;
    }
}
