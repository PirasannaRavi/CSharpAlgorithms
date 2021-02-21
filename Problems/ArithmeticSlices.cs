using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ArithmeticSlices
    {
        public int NumberOfArithmeticSlicesBad(int[] A)
        {
            var diff = 0;
            var numberOfArithmeticSlices = 0;
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 2; j < A.Length; j++)
                {
                    for (int k = i + 1; k <= j; k++)
                    {
                        if (k == i + 1)
                        {
                            diff = A[k] - A[i];
                            continue;
                        }
                        if (diff != A[k] - A[k - 1])
                        {
                            break;
                        }
                        if (k == j)
                        {
                            numberOfArithmeticSlices++;
                        }
                    }
                }
            }
            return numberOfArithmeticSlices;
        }

        public int NumberOfConsecutiveArithmeticSlices(int[] A)
        {
            // Using Dynamic Programing
            var count = 0;
            var result = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] - A[i - 1] == A[i - 1] - A[i - 2])
                {
                    count++;
                    result += count;
                }
                else
                {
                    count = 0;
                }
            }
            return result;
        }

        public int NumberOfSubsequenceArithmeticSlices(int[] A)
        {
            throw new NotImplementedException();
        }
    }
}
