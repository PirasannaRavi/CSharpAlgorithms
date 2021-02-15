using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class KWeakestRowsInAMatrix
    {
        private int NumberOfSoldiers(int[] values)
        {
            var low = 0;
            var hi = values.Length;

            while (low < hi)
            {
                var mid = low + (hi - low) / 2;
                if (values[mid] == 1)
                {
                    low = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }
            return low;
        }
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int rows = mat.Length;
            int columns = mat[0].Length;
            var scores = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                var score = NumberOfSoldiers(mat[i]) * rows + i;
                scores[i] = score;
            }
            Array.Sort(scores);
            var returnArray = new int[k];
            Array.Copy(scores, returnArray, k);

            for (int i = 0; i < k; i++)
            {
                returnArray[i] = returnArray[i] % rows;
            }

            return returnArray;
        }
    }
}
