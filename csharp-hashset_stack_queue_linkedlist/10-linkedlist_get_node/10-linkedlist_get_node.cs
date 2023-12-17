using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int i = 0;

        if (n >= 0 && n < myLList.Count)
            foreach (int item in myLList)
                if (i++ == n)
                    return item;
                
        return 0;
    }
}
