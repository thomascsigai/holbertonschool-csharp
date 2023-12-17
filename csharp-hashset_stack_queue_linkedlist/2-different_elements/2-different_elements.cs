using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var uniqueToFirst = list1.Except(list2).ToList();
        var uniqueToSecond = list2.Except(list1).ToList();

        var result = new List<int>();
        result.AddRange(uniqueToFirst);
        result.AddRange(uniqueToSecond);

        result.Sort();
        return result;
    }
}
