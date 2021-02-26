using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ValidateStackSequencesAlgo
    {
        public bool ValidateStackSequences1(int[] pushed, int[] popped)
        {
            if (pushed.Length == 0 && popped.Length == 0)
            {
                return true;
            }
            var tryStack = new Stack<int>();
            tryStack.Push(pushed[0]);
            var j = 1;
            for (int i = 0; i < popped.Length; i++)
            {
                if (tryStack.Any())
                {
                    if (tryStack.Peek() == popped[i])
                    {
                        tryStack.Pop();
                        continue;
                    }
                }
                if (j >= pushed.Length)
                {
                    return false;
                }
                while (j < pushed.Length && popped[i] != pushed[j])
                {
                    tryStack.Push(pushed[j]);
                    j++;
                }
                j++;
            }

            return true;
        }

        public bool validateStackSequences(int[] pushed, int[] popped)
        {
            int N = pushed.Length;
            var stack = new Stack<int>();

            int j = 0;
            foreach (var x in pushed)
            {
                stack.Push(x);
                while (stack.Any() && j < N && stack.Peek() == popped[j])
                {
                    stack.Pop();
                    j++;
                }
            }

            return j == N;
        }
    }
}

