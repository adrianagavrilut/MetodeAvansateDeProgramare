using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11C_12_22
{
    public static class Engine
    {
        public static Random rnd = new Random();
        public static int min = -100;
        public static int max = 100;
        public static int[,] A;
        public static int[] T;
        public static int n;


        public static void LoadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);
            n = int.Parse(reader.ReadLine());
            A = new int[n, n];
            T = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = reader.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    A[i, j] = int.Parse(buffer[j]);
            }
            string[] data = reader.ReadLine().Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                T[i] = int.Parse(data[i]);
            }
            reader.Close();
        }
    }
}
