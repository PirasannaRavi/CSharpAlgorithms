using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ValidAnagram
    {
        public bool IsAnagram1(string s, string t)
        {
            // Runtime: 676 ms
            // Memory Usage: 46.2 MB
            if (s.Length != t.Length)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                var indexOfChar = t.IndexOf(s[i]);
                if (indexOfChar > -1)
                {
                    t = t.Remove(indexOfChar, 1);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnagramBestCase(string s, string t)
        {
            // Runtime: 88 ms
            // Memory Usage: 24.5 MB

            if (s.Length != t.Length)
            {
                return false;
            }

            var counter = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (counter.ContainsKey(s[i]))
                {
                    counter[s[i]]++;
                }
                else
                {
                    counter.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (counter.ContainsKey(t[i]))
                {
                    counter[t[i]]--;
                    if (counter[t[i]] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnagram3(string s, string t)
        {
            // Runtime: 140 ms
            // Memory Usage: 26.2 MB

            if (s.Length != t.Length)
            {
                return false;
            }

            var sortedS = s.ToCharArray().OrderBy(c => c);
            var sortedT = t.ToCharArray().OrderBy(c => c);

            return sortedS.SequenceEqual(sortedT);
        }
    }
}
