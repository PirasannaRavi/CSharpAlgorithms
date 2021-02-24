using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class LongestWordInDictionaryThroughDeleting
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            d = d.OrderByDescending(i => i.Length).ThenBy(i => i).ToList();
            foreach (var word in d)
            {
                int i = 0;
                int j = 0;
                var intermitentString = s.Substring(0);
                for (; j < word.Length; j++)
                {
                    if (intermitentString.Length > i)
                    {
                        intermitentString = intermitentString.Substring(i);
                        var index = intermitentString.IndexOf(word[j]);
                        if (index > -1)
                        {
                            i = index + 1;
                            continue;
                        }
                    }
                    break;
                }
                if (j == word.Length)
                {
                    return word;
                }
            }
            return string.Empty;
        }
        public string FindLongestWord1(string s, IList<string> d)
        {
            var charArray = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                charArray[s[i] - 'a']++;
            }
            d = d.OrderByDescending(i => i.Length).ThenBy(i => i).ToList();
            foreach (var word in d)
            {
                var tempCharArray = new int[26];
                Array.Copy(charArray, tempCharArray, charArray.Length);

                int i = 0;
                for (; i < word.Length; i++)
                {
                    var count = --tempCharArray[word[i] - 'a'];
                    if (count < 0)
                    {
                        break;
                    }
                }
                if (i == word.Length)
                {
                    return word;
                }
            }
            return string.Empty;
        }
    }
}
