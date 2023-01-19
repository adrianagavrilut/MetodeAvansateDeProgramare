using System;
using System.Collections.Generic;
using System.IO;

namespace _12C_01_12
{
    class Program
    {
        static int[,] matrix;
        static int n, m;

        static void Main(string[] args)
        {
            matrix = ReadMatrixFromFile(@"..\..\TextFile1.txt");
            View();
            for (int i = 0; i < 10; i++)
            {
                Tick();
                View();
            }
        }

        private static void Tick()
        {
            int[,] M = new int[n, m]; //matrice intermediara
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int s = 0;

                    if (i - 1 >= 0 && j - 1 >= 0)
                        if (matrix[i - 1, j - 1] == 1)
                            s++;
                    if (i - 1 >= 0)
                        if (matrix[i - 1, j] == 1)
                            s++;
                    if (i - 1 >= 0 && j + 1 < m)
                        if (matrix[i - 1, j + 1] == 1)
                            s++;
                    if (j + 1 < m)
                        if (matrix[i, j + 1] == 1)
                            s++;
                    if (j + 1 < m && i + 1 < n)
                        if (matrix[i + 1, j + 1] == 1)
                            s++;
                    if (i + 1 < n)
                        if (matrix[i + 1, j] == 1)
                            s++;
                    if (i + 1 < n && j - 1 >= 0)
                        if (matrix[i + 1, j - 1] == 1)
                            s++;
                    if (j - 1 >= 0)
                        if (matrix[i, j - 1] == 1)
                            s++;

                    if (s % 2 == 0)
                        M[i, j] = 0;
                    else
                        M[i, j] = 1;
                }
            }
            matrix = M;
        }

        private static void View()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] ReadMatrixFromFile(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            List<string> lines = new List<string>();
            string line;
            while ((line = load.ReadLine()) != null)
                lines.Add(line);
            load.Close();
            n = lines.Count;
            m = lines[0].Split(' ').Length;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] data = lines[i].Split(' ');
                for (int j = 0; j < m; j++)
                    matrix[i, j] = int.Parse(data[j]);
            }
            return matrix;
        }
    }
}
