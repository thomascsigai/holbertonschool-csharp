using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> isDivisibleList = new List<bool>();

        foreach (int element in myList)
        {
            if (element % 2 == 0)
                isDivisibleList.Add(true);
            else
                isDivisibleList.Add(false);
        }

        return isDivisibleList;
    }
}
