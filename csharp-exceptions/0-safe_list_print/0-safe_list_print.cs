﻿using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        try
        {
            for (i = 0; i < n; i++)
                Console.WriteLine("{0}", myList[i]);
        }
        catch {}
        
        return i;
        
    }
}
