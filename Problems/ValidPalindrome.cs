using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                while (i < j && !((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9')))
                {
                    i++;
                }
                while (i < j && !((s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9')))
                {
                    j--;
                }

                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public bool TryPalindromeByRemovingOneChar(string s)
        {
            // Note: The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    if (IsPalindrome(s, i + 1, j))
                    {
                        return true;
                    }
                    else if (IsPalindrome(s, i, j - 1))
                    {
                        return true;
                    }
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {

                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
