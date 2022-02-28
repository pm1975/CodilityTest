using System;
namespace CodilityTest
{
    public class BinaryGap
    {
        public static void Main2(string[] args)
        {
            BinaryGap binaryGap = new BinaryGap();
            Console.WriteLine(binaryGap.solution(9));
            Console.WriteLine(binaryGap.solution(1041));
            Console.WriteLine(binaryGap.solution(32));
            //Console.WriteLine(BinaryGapMaxLengthByIterating(9));
            Console.WriteLine(BinaryGapMaxLengthByIterating(1041));
            //Console.WriteLine(BinaryGapMaxLengthByIterating(32));
        }

        public string solution(int value)
        {
            return Convert.ToString(value, 2);
        }

        public static int BinaryGapMaxLengthByIterating(int N)
        {
            int max_gap = 0;
            int gap = 0;
            char mask = '1';

            string binary = Convert.ToString(N, 2);

            int i = 0;
            while (i < binary.Length && binary[i] != mask)
            {
                ++i;
            }

            for (; i < binary.Length; ++i)
            {
                if (binary[i] == mask)
                {
                    if (gap > max_gap)
                    {
                        max_gap = gap;
                    }
                    gap = 0;
                }
                else
                {
                    ++gap;
                }
            }
            return max_gap;
        }

    }
}
