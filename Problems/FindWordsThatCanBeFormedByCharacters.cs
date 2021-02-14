using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Problems
{
    public class FindWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(string[] words, string chars)
        {
            int count = 0;
            foreach (var word in words)
            {
                bool isWordFound = true;
                var hashSet = ResetHash(chars);
                for (int i = 0; i < word.Length; i++)
                {
                    if (hashSet.ContainsKey(word[i]))
                    {
                        hashSet[word[i]]--;
                        if (hashSet[word[i]] < 0)
                        {
                            isWordFound = false;
                            break;
                        }
                    }
                    else
                    {
                        isWordFound = false;
                        break;
                    }
                }

                if (isWordFound)
                {
                    count += word.Length;
                }

                hashSet = null;
            }

            return count;
        }
        private Dictionary<char, int> ResetHash(string chars)
        {
            var hashSet = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (hashSet.ContainsKey(chars[i]))
                {
                    hashSet[chars[i]]++;
                }
                else
                {
                    hashSet.Add(chars[i], 1);
                }
            }
            return hashSet;
        }
    }
}
