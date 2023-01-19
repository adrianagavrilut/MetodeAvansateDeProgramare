using System;

/// <summary>
/// Algoritmi Divide et Conquer
/// </summary>
namespace _04C_10_27_2
{
    /// <summary>
    /// Turnurile din Hanoi 
    /// </summary>
    class Program
    {
        static int contor = 0;

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //pb pentru 3 tije
            //hanoiTreiTije(n, 'A', 'B', 'C');

            //pb pentru 4 tije
            hanoiPatruTije(n, 'A', 'B', 'C', 'D');

            Console.WriteLine(contor);
            Console.ReadKey();
        }

        private static void hanoiPatruTije(int n, char A, char B, char C, char D)
        {
            if (n == 1)
            {
                Console.WriteLine(A + "-->" + D);
                contor++;
            }
            else if (n == 2)
            {
                hanoiPatruTije(1, A, B, D, C);
                hanoiPatruTije(1, A, B, C, D);
                hanoiPatruTije(1, C, A, B, D);
            }
            else
            {
                hanoiPatruTije(n - 2, A, C, D, B);
                hanoiPatruTije(1, A, B, D, C);
                hanoiPatruTije(1, A, B, C, D);
                hanoiPatruTije(1, C, A, B, D);
                hanoiPatruTije(n - 2, B, A, C, D);
            }
        }

        static void hanoiTreiTije(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine(A + "-->" + C);
                contor++;
            }
            else
            {
                hanoiTreiTije(n - 1, A, C, B);
                hanoiTreiTije(1, A, B, C);
                hanoiTreiTije(n - 1, B, A, C);
            }
        }
    }
}