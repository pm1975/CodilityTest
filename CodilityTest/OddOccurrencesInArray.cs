using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    public class OddOccurrencesInArray
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("OddOccurrencesInArray");
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine($"[{string.Join(", ", A)}]");
            int v = Solution(A);
            Console.WriteLine(v);
        }

        private static int Solution(int[] a)
        {
            List<int> list = a.ToList();
            IEnumerable<int> duplicates = list.GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(x => x.Key);
            Console.WriteLine(string.Join(",", duplicates));
            return duplicates.First();
        }
    }
}
