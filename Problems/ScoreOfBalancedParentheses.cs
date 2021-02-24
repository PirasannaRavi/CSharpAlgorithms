using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ScoreOfBalancedParentheses
    {
        public int ScoreOfParentheses(string S)
        {
            var balancedStack = new Stack<int>();
            balancedStack.Push(0);
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    balancedStack.Push(0);
                }
                else if (S[i] == ')')
                {
                    var ultimateValue = balancedStack.Pop();
                    var penultimateValue = balancedStack.Pop();
                    balancedStack.Push(penultimateValue + Math.Max(ultimateValue * 2, 1));
                }
            }
            return balancedStack.Pop();
        }
    }
}
