using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10C_12_15
{
    class Program
    {
        public static string str = "EXCELLENT";
        public static int contor = 0;
        public static List<string> list = new List<string>();//lista sortata
        public static List<string> list2 = new List<string>();//din lista sortata alegem doar cele distincte

        static void Main(string[] args)
        {
            T(5); //pb turnuri
            Console.WriteLine();

            //pb anagrame distincte

/*            int n = str.Length;
            int[] s = new int[n];
            bool[] b = new bool[n];
            BkPermString(0, n, s, b);
            Console.WriteLine(contor);
            //sortam lista
            list.Sort(delegate(string x, string y) { return x.CompareTo(y); });
            //foreach (string strng in list)
              //  Console.WriteLine(strng);
            list2.Add(list[0]);
            for (int i = 1; i < list.Count; i++)
                if (list[i] != list2[list2.Count - 1])
                    list2.Add(list[i]);
            //foreach (string strng2 in list2)
              //  Console.WriteLine(strng2);
            Console.WriteLine(list2.Count);//raspuns final (calea lunga)
            Console.WriteLine(Factorial((ulong)n));
            Console.WriteLine(Factorial2((ulong)n));
            Console.WriteLine(Factorial((ulong)n) / (Factorial(2) * Factorial(3)));//raspuns final (rapid) !

            //final form
            *//*for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] > str[j])
                    {
                        char aux = str[i];
                        str[i] = str[j];
                        str[j] = aux;
                        //nu facem cu bubble sort, nu le mai sortam
                        //nu merge, deoarece trebuie facut de fapt doar un couunting pt nr de aparitii
                    }
                }
            }*/
            int[] nrApar = new int[255];
            for (int i = 0; i < str.Length; i++)
                nrApar[(int)str[i]]++;
            for (int i = 0; i < 255; i++)
                Console.Write(nrApar[i]);
            Console.WriteLine();
            ulong numitor = 1;
            for (int i = 0; i < 255; i++)
                if (nrApar[i] > 1)
                    numitor *= Factorial((ulong)nrApar[i]);
            Console.WriteLine(Factorial((ulong)str.Length) / numitor);//raspunsul final cel mai rapid, FORMULA  !!!!!!

        }

        public static ulong Factorial2(ulong n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial2(n - 1);
            return n;
        }

        public static ulong Factorial(ulong n)
        {
            ulong p = 1;
            for (ulong i = 1; i <= n; i++)
                p *= i;
            return p;
        }

        public static string Anagrama(int[] s)
        {
            string toR = "";
            for (int i = 0; i < s.Length; i++)
            {
                toR += str[s[i]];
            }
            return toR;
        }

        public static void BkPermString(int k, int n, int[] s, bool[] b)
        {
            if (k >= n)
            {
                //afisam o solutie
                //Console.WriteLine(Anagrama(s));
                list.Add(Anagrama(s));
                contor++;
                /*for (int i = 0; i < n; i++)
                    Console.Write(s[i] + " ");
                Console.WriteLine();*/
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        s[k] = i;
                        BkPermString(k + 1, n, s, b);
                        b[i] = false;
                    }
                }
            }
        }

        public static void T(int n)
        {
            if (n == 1)
                Console.Write("1 ");
            else
            {
                T(n - 1);
                Console.Write(n + " ");
                T(n - 1);
            }
        }
    }
}
