using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index + 1 > myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        for (int i = 0; i < length; i++)
            if (i == index)
                myList.Remove(myList[i]);

        return myList;
    }

}
