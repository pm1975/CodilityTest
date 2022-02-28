using System;
using System.Collections.Generic;
using System.IO;

namespace CodilityTest
{
    public class ConsistentFragment
    {
        //Remove consistent fragment from string
        /*
         Examples:
1. Given S = "abccac", the function should return 1.  letter "c" remaining.
2. Given S = "abcdabcdabcd" ("abcd" stated three times), the function should return 2. To achieve that, you can, for example, remove the first five letters from S ("abcda") in the first move, and the last five letters ("dabcd") in the second move. The remaining fragment would be "bc".
3. Given S = "axaabyab", the function should return 0. It is possible to remove all letters by removing the substring "axaa" in the first move, and then "byab" in the second.

         */
        public static void Main2(string[] args)
        {
            Console.WriteLine(solution("axaabyab"));
        }

        public static int solution(string S)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string newString = S;
            Console.WriteLine(newString);
            for (int i = 0; i < S.Length; i++)
            {
                if (letters.ContainsKey(S[i]))
                {
                    if (i + 1 < S.Length && S[i] == S[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        int start = letters[S[i]];
                        int length = (i + 1) - start;
                        newString = S.Remove(start, length);
                        return solution(newString);
                    }
                }
                else
                {
                    letters.Add(S[i], i);
                }
            }
            return newString.Length;
        }


    }
}
