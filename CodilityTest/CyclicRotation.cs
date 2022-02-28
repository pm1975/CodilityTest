using System;
namespace CodilityTest
{
    public class CyclicRotation
    {
        public static void Main2(string[] args)
        {
            Console.WriteLine("CyclicRotation");
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            Console.WriteLine($"[{string.Join(", ", A)}]");
            int[] v = Solution(A, 3);
            Console.WriteLine($"[{string.Join(", ", v)}]");
        }

        private static int[] Solution(int[] A, int K)
        {
            if (A.Length > 0)
            {
                for (int i = 0; i < K; i++)
                {
                    int last = A[A.Length - 1];
                    for (int j = A.Length - 2; j >= 0; j--)
                    {
                        A[j + 1] = A[j];
                    }
                    A[0] = last;
                }
            }
            return A;
        }
    }
}
