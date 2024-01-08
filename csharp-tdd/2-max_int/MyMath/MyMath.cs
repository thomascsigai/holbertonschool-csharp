using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Defines arithmetic operations implementations.</summary>
    public class Operations
    {
        ///<summary>Finds and returns max integer in a list of integers.</summary>
        ///<param name="nums">The list.</param>
        ///<returns>The max integer in the list.</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;

            int max = nums[0];

            foreach (int element in nums)
            {
                if (element > max)
                    max = element;
            }

            return max;
        }
    }
}
