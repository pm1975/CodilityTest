using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    class FindFirstNoExistGreaterThan0
    {
        public static void Main2(string[] args)
        {
            FindFirstNoExistGreaterThan0 program = new FindFirstNoExistGreaterThan0();
            int[] array = { 1, 3, 6, 4, 1, 2 };
            int v = program.solution(array);
            Console.WriteLine(v);
            int[] array1 = { 1, 2, 3 };
            v = program.solution(array1);
            Console.WriteLine(v);
            int[] array2 = { -1, -3 };
            v = program.solution(array2);
            Console.WriteLine(v);
        }

        public int solution(int[] A)
        {
            List<int> list = A.ToList();
            list.Sort();
            int last = list.Last();
            if (last < 1)
                return 1;
            else
            {
                for (int i = 1; i < last; i++)
                {
                    if (!list.Contains(i))
                        return i;
                }
                return ++last;
            }
        }
    }
}
