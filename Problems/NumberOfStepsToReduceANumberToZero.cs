using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class NumberOfStepsToReduceANumberToZero
    {
        public int NumberOfSteps(int num)
        {
            int stepsToZero = 0;
            while (num > 0)
            {
                stepsToZero++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                    continue;
                }
                num = num - 1;
            }
            return stepsToZero;
        }
    }
}
