using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class BrokenCalculator
    {
        public int BrokenCalc(int X, int Y)
        {
            // 02 -> 9
            // 01. 02 x 2
            // 02. 04 - 1
            // 03. 03 x 2
            // 04. 06 - 1
            // 05. 05 x 2
            // 06. 10 - 1
            int numOfOperations = 0;
            while (Y > X)
            {
                numOfOperations++;
                if (Y % 2 == 1)
                    Y++;
                else
                    Y /= 2;
            }

            return numOfOperations + X - Y;
        }
    }
}
