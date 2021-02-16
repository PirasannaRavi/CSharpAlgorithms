using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class LetterCasePermutation
    {
        public IList<string> GetLetterCasePermutation(string S)
        {
            S = S.ToLower();
            var combiStrings = new List<string>();
            combiStrings.Add(S);

            var givenChars = S.ToCharArray();
            for (var i = 0; i < givenChars.Length; i++)
            {
                if (givenChars[i] >= '0' && givenChars[i] <= '9')
                {
                    continue;
                }

                var newCombiStrings = new List<string>();
                for (var j = 0; j < combiStrings.Count; j++)
                {
                    var newString = new char[givenChars.Length];
                    Array.Copy(combiStrings[j].ToCharArray(), newString, givenChars.Length);
                    newString[i] = Char.ToUpper(newString[i]);
                    newCombiStrings.Add(new string(newString));
                }
                combiStrings.AddRange(newCombiStrings);
            }

            return combiStrings;
        }
    }
}
