using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class SearchA2DMatrixII
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            var x = 0;
            var y = n - 1;

            while (x < m && y >= 0)
            {
                if (matrix[x][y] == target)
                {
                    return true;
                }
                if (matrix[x][y] > target)
                {
                    y--;
                }
                else
                {
                    x++;
                }
            }
            return false;
        }
    }
}
