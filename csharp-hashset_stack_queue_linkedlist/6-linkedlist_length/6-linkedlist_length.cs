﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int numberOfElements = 0;

        foreach (var item in myLList)
            numberOfElements++;
        
        return numberOfElements;
    }
}
