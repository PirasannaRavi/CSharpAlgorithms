using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class LetterCasePermutation
    {
        public IList<string> GetLetterCasePermutation(string S)
        {
            // BFS - Using Queue
            S = S.ToLower();
            var combiStrings = new Queue<string>();
            combiStrings.Enqueue(S);

            for (var i = 0; i < S.Length; i++)
            {
                if (Char.IsDigit(S[i]))
                {
                    continue;
                }

                var size = combiStrings.Count;
                for (var j = 0; j < size; j++)
                {
                    var cur = combiStrings.Dequeue();
                    combiStrings.Enqueue(cur);

                    var newString = new char[S.Length];
                    Array.Copy(cur.ToCharArray(), newString, S.Length);
                    newString[i] = Char.ToUpper(newString[i]);
                    combiStrings.Enqueue(new string(newString));
                }
            }

            return combiStrings.ToList();
        }
    }
}
