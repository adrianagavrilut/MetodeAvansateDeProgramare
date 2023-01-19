using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01C_10_06
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"../../TextFile1.txt");
            int n = int.Parse(load.ReadLine());
            int[,] matrix = new int[n, n];
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] t = buffer.Split(' ');
                int Ns = int.Parse(t[0]);
                int Ne = int.Parse(t[1]);
                matrix[Ns, Ne] = 1;
                matrix[Ne, Ns] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

            int nrImpar = 0;
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == 1)
                        s++;
                if (s % 2 == 1)
                    nrImpar++;
            }
            Console.WriteLine();
            if (nrImpar > 2)
                Console.WriteLine("Graful nu este Eulerian");
            else
                Console.WriteLine("Graful este Eulerian");
            Console.WriteLine();
        }
    }
}
