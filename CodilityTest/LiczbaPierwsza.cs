using System;
namespace CodilityTest
{
    public class LiczbaPierwsza
    {
        /*
        Logika polega na znalezieniu liczby całkowitej mniejszej lub równej pierwiastkowi kwadratowemu z wejściowej liczby całkowitej.
        Jeśli istnieje dzielnik liczby, który jest mniejszy niż pierwiastek kwadratowy z liczby,
        wówczas będzie dzielnik liczby, który jest większy niż pierwiastek kwadratowy liczby.
        Dlatego musimy przejść do pierwiastka kwadratowego z liczby.
         */

        public static void Main2(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbe pierwszą: ");
                string v = Console.ReadLine();
                if (v.ToLower().Equals("close"))
                {
                    break;
                }
                int.TryParse(v, out int expression);

                if (FindPrime(expression))
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));
            Console.WriteLine(squareRoot);

            for (int i = 3; i <= squareRoot; i += 2)
                if (number % i == 0) return false;

            return true;
        }
    }
}
