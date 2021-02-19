using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class MinimumRemoveToMakeValidParentheses
    {
        public string MinRemoveToMakeValid(string s)
        {
            var openParenthesesStack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    openParenthesesStack.Push(i);
                    continue;
                }
                if (s[i] == ')')
                {
                    if (openParenthesesStack.Any())
                    {
                        openParenthesesStack.Pop();
                        continue;
                    }
                    s = s.Remove(i, 1);
                    i--;
                }
            }
            while (openParenthesesStack.Count > 0)
            {
                s = s.Remove(openParenthesesStack.Pop(), 1);
            }
            return s;
        }
    }
}
