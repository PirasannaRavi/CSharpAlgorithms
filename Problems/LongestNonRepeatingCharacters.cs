using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class LongestNonRepeatingCharacters
    {
        public int GetLongestNonRepeatingCharacters(string s)
        {
            var charArray = s.ToCharArray();
            var distinctCharCollection = new Dictionary<string, int>();
            var currentString = string.Empty;
            for (var i = 0; i < s.Length; i++)
            {
                if (currentString.Contains(charArray[i]))
                {
                    if (!distinctCharCollection.ContainsKey(currentString))
                    {
                        distinctCharCollection.Add(currentString, currentString.Length);
                    }

                    i = s.Substring(0, i).LastIndexOf(currentString) + currentString.IndexOf(charArray[i]) + 1;

                    if (distinctCharCollection.Max(d => d.Value) >= s.Length - i)
                    {
                        break;
                    }
                    currentString = string.Empty;
                }
                currentString += charArray[i];
            }
            if (!distinctCharCollection.ContainsKey(currentString))
            {
                distinctCharCollection.Add(currentString, currentString.Length);
            }
            return distinctCharCollection.Max(d => d.Value);
        }
    }
}
