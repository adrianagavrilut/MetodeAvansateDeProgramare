using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace _09C_12_08
{
    public class Graph
    {
        public int n;
        public int[,] matrixAd;//matricea de adiacenta
        public int[,] matrixDr;//matricea de drmuri

        public Graph()
        {
        }

        public void LoadFromFile(string filename)
        {
            TextReader load = new StreamReader(filename);
            n = int.Parse(load.ReadLine());
            matrixAd = new int[n + 1, n + 1];
            matrixDr = new int[n + 1, n + 1];
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] data = buffer.Split(' ');
                int x = int.Parse(data[0]);
                int y = int.Parse(data[1]);
                matrixAd[x, y] = 1;
            }
            load.Close();
        }

        public List<string> View(int[,] a)
        {
            List<string> list = new List<string>();
            string buffer;
            for (int i = 1; i <= n; i++)
            {
                buffer = "";
                for (int j = 1; j <= n; j++)
                    buffer += a[i, j];
                list.Add(buffer);
            }
            return list;
        }

        public void RoyWarshall()
        {
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    matrixDr[i, j] = matrixAd[i, j];
            for (int k = 1; k <= n; k++)
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= n; j++)
                        if (i != j && matrixDr[i, j] == 0)
                            matrixDr[i, j] = matrixDr[i, k] * matrixDr[k, j];       
        }

        public List<string> CTC()//componente tare conexe
        {
            List<string> ctc = new List<string>();
            string buffer;
            int[] p = new int[n + 1];
            for (int i = 1; i <= n; i++)
                p[i] = 0;
            for (int i = 1; i <= n; i++)
            {
                buffer = "";
                if (p[i] == 0)
                {
                    buffer += i + " ";
                    p[i] = 1;
                    for (int j = 1; j <= n; j++)
                    {
                        if (matrixDr[i,j] * matrixDr[j, i] == 1)
                        {
                            buffer += j + " ";
                            p[j] = 1;
                        }
                    }
                    if (buffer != "")
                        ctc.Add(buffer);
                }
            }
            return ctc;
        }
    }
}