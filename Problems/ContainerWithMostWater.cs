using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ContainerWithMostWater
    {
        public int MaxAreaNormalSolution(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    var smallestHeight = Math.Min(height[i], height[j]);
                    maxArea = Math.Max(maxArea, smallestHeight * (j - i));
                }
            }

            return maxArea;
        }
        public int MaxAreaBetterSolution(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxArea = 0;

            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
                _ = height[left] < height[right] ? left++ : right--;
            }

            return maxArea;
        }
    }
}
