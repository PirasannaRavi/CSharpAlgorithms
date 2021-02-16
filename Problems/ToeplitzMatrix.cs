using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            var dic = new Dictionary<int, int>();
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    var key = x - y;
                    if (dic.ContainsKey(key))
                    {
                        if (dic[key] != matrix[x][y])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        dic.Add(key, matrix[x][y]);
                    }
                }
            }
            return true;
        }
    }
}
