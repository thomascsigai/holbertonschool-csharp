using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count > 0)
        {
            LinkedListNode<int> firstNode = new LinkedListNode<int>(myLList.First.Value);
            myLList.RemoveFirst();
            return firstNode.Value;
        }
        else
        {
            return 0;
        }
    }
}
