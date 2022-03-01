using System;
namespace CodilityTest
{
    public class TapeEquilibrium
    {
        public static void Main(string[] args)
        {
            int[] a = { 3, 1, 2, 4, 3 };
            int b = Solution(a);
            Console.WriteLine(b);
        }

        private static int Solution(int[] a)
        {
            //38%
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += a[j];
                }
                for (int j = i; j < a.Length; j++)
                {
                    sum2 += a[j];
                }
                int v = Math.Abs(sum1 - sum2);
                if (v < min)
                {
                    min = v;
                }
            }
            return min;
        }
    }
}
