using System;
namespace CodilityTest
{
    public class FrogJmp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FrogJmp");
            int x = 10;
            int y = 85;
            int d = 30;
            int i = Solution(x, y, d);
            Console.WriteLine(i);
        }

        private static int Solution(int x, int y, int d)
        {
            int s = (y - x) / d;
            int m = (y - x) % d;
            return m > 0 ? s + 1 : s;
        }
    }
}
