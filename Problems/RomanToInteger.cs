using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var romanNumberValues = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            var substractSet = new Dictionary<char, char[]>()
            {
                { 'I', new[] { 'V', 'X' } },
                { 'X', new[] { 'L', 'C' } },
                { 'C', new[] { 'D', 'M' } },
            };
            var number = 0;
            char previousChar = Char.MinValue;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var value = romanNumberValues[s[i]];
                if (substractSet.ContainsKey(s[i]) && substractSet[s[i]].Contains(previousChar))
                {
                    number -= value;
                }
                else
                {
                    number += value;
                }

                previousChar = s[i];
            }

            return number;
        }

        public int RomanToIntBetter(string s)
        {
            var romanNumberValues = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            var number = 0;
            int i = 0;
            for (; i < s.Length - 1; i++)
            {
                if (romanNumberValues[s[i]] >= romanNumberValues[s[i + 1]])
                {
                    number += romanNumberValues[s[i]];
                    continue;
                }
                number -= romanNumberValues[s[i]];
            }

            number += romanNumberValues[s[i]];

            return number;
        }
    }
}
