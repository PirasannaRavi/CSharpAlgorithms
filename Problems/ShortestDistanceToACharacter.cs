using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ShortestDistanceToACharacter
    {
        public int[] ShortestToChar(string s, char c)
        {
            var answers = new int[s.Length];
            for (var i = 0; i < s.Length; i++)
            {
                var leftSideString = s.Substring(0, i);
                var rightSideString = s.Substring(i, s.Length - i);

                var leftSideIndex = leftSideString.LastIndexOf(c);
                var distanceFromLeft = leftSideIndex != -1 ? i - leftSideIndex : int.MaxValue;

                var rightSideIndex = rightSideString.IndexOf(c);
                var distanceFromRight = rightSideIndex != -1 ? rightSideIndex : int.MaxValue;

                var smallestNumber = distanceFromLeft < distanceFromRight ? distanceFromLeft : distanceFromRight;
                answers[i] = smallestNumber;
            }

            return answers;
        }
    }
}
