﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int numberOfKeys = 0;

        foreach (KeyValuePair<string, string> element in myDict)
            numberOfKeys++;

        return numberOfKeys;
    }
}
