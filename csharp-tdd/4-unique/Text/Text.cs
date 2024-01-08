using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Defines string manipulation tools.</summary>
    public class Str
    {
        ///<summary>Finds the index of the first non-repeating character of a string.</summary>
        ///<param name="s">The string to check.</param>
        ///<returns>The index of the char.</returns>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charFrequency[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
