using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    public class PermMissingElem
    {
        public static void Main2(string[] args)
        {
            int[] a = { 2, 3, 1, 5 };
            int b = Solution(a);
            Console.WriteLine(b);
        }

        private static int Solution(int[] a)
        {
            //50%
            List<int> list = a.ToList();
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != (i + 1))
                    return i + 1;
            }
            return 0;
        }
    }
}
