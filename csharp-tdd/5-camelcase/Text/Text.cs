using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Defines string manipulation tools.</summary>
    public class Str
    {
        ///<summary>Determines how many words are in a string.</summary>
        ///<param name="s">The string to check.</param>
        ///<returns>Number of words.</returns>
        public static int CamelCase(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;

            int numberOfWords = 1;

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    numberOfWords++;
            }

            return numberOfWords;
        }
    }
}
