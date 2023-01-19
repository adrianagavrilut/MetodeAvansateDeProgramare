using System;

namespace _04C_10_27_BinarySearch
{
    class Program
    {
        //static int c = 0;
        //static int nCalculator, nUtilizator;
        static Random rnd = new Random();
        static int cnt1 = 0, cnt2 = 0;

        static void Main(string[] args)
        {
            /*nCalculator = rnd.Next(1000);
            do{
                nUtilizator = int.Parse(Console.ReadLine());
                cnt1++;
                if (nUtilizator < nCalculator)
                {
                    //Console.WriteLine("Incearca un numar mai  mare");
                    Console.WriteLine("Too low");
                }
                else if (nUtilizator > nCalculator)
                {
                    Console.WriteLine("Too high");
                }
            } while (nUtilizator != nCalculator);
            Console.WriteLine($"Ai reusit din {cnt1} incercari");*/
            /* int n = 10000, k = 10000, t = 5000;
             int[] v = new int[n];
             for (int i = 0; i < n; i++)
             {
                 v[i] = rnd.Next(k);
             }
             int[] x = new int[t]; //cautam elementele vect x in vectorul v
             for (int i = 0; i < t; i++)
             {
                 x[i] = rnd.Next(k);
             }
             //found naiv
             for (int i = 0; i < t; i++)
             {
                 Found(v, x[i]);
             }
             Console.WriteLine(cnt1);

             //sortare
             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = i + 1; j < n; j++)
                 {
                     if (v[i] > v[j])
                     {
                         int aux = v[i];
                         v[i] = v[j];
                         v[j] = aux;
                     }
                 }
             }

             //bs
             for (int i = 0; i < t; i++)
             {
                 Found(v, x[i], 0, v.Length - 1);
             }
             Console.WriteLine(cnt2 + 700000);*/
            int n = 10, k = 10, t = 5;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(k);
            }
            int[] x = new int[t]; //cautam elementele vect x in vectorul v
            for (int i = 0; i < t; i++)
            {
                x[i] = rnd.Next(k);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            int a = rnd.Next(n);
            Console.WriteLine(a);/*
            for (int i = 0; i < t; i++)
            {
                if(Found(v, x[i], 0, v.Length - 1))
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);
            }*/
            if (Found(v, a, 0, v.Length - 1))
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        //found DC - BinarySearch
        static bool Found(int[] v, int x, int st, int dr)
        {
            cnt2++;
            if (st <= dr)
            {
                int mij = (st + dr) / 2;
                if (v[mij] == x)
                    return true;
                else if (x < v[mij])
                    return Found(v, x, st, mij - 1);
                else
                    return Found(v, x, mij + 1, dr);
            }
            else
                return false;
        }

        //found naiv
        static bool Found(int[] v, int x)
        {
            for (int i = 0; i < v.Length; i++)
            {
                cnt1++;
                if (v[i] == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
