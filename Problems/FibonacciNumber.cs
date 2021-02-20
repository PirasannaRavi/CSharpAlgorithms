using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class FibonacciNumber
    {
        // Normal Recursive Method. Inefficient for large n.
        public long Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        // Fib with Memoization (Caching). Better than above method.
        Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };
        public long FibMemo(int n)
        {
            if (_memo.ContainsKey(n))
            {
                return _memo[n];
            }

            var value = FibMemo(n - 1) + FibMemo(n - 2);
            _memo.Add(n, value);
            return value;
        }

        // Bottom-Up Approach. Best Method.
        public long FibBottomUp(int n)
        {
            long f1 = 0;
            long f2 = 1;
            long nextValue = 0;
            for (int i = 2; i <= n; i++)
            {
                nextValue = f1 + f2;
                f1 = f2;
                f2 = nextValue;
            }

            return nextValue;
        }
    }
}
