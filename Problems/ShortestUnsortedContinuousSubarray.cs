using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int len = nums.Length - 1, left = -1, right = -1, max = nums[0], min = nums[len];

            for (int i = 1; i < nums.Length; i++)
            {
                int a = nums[i], b = nums[len - i];

                if (a < max)
                    right = i;
                else
                    max = a;

                if (b > min)
                    left = i;
                else
                    min = b;
            }
            var returnVal = Math.Max(0, left + right - len + 1);
            return returnVal;
        }
    }
}
