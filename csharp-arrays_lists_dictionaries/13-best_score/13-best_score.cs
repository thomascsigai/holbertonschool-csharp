using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string keyMaxValue = "None";
        int maxValue = -1;

        foreach (KeyValuePair<string, int> element in myList)
            if (element.Value > maxValue)
            {
                keyMaxValue = element.Key;
                maxValue = element.Value;
            }

        return keyMaxValue;
    }
}
