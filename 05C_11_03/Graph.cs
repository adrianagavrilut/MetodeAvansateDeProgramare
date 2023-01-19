using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace _05C_11_03
{
    public class Graph
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;
        public int[,] matrix;

        private List<int> toR;

        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);
            int n = int.Parse(reader.ReadLine());
            matrix = new int[n, n];
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine();
                Vertex local = new Vertex(buffer);
                local.idx = i;
                Vertices.Add(local);
            }
            while ((buffer = reader.ReadLine()) != null)
            {
                Edge edge = new Edge(buffer);
                Edges.Add(edge);
            }
            reader.Close();

            foreach (Edge edge in Edges)
            {
                matrix[edge.start.idx, edge.end.idx] = 1;
                matrix[edge.end.idx, edge.start.idx] = 1;
            }
        }

        public void Draw(Graphics h)
        {
            foreach (Vertex v in Vertices)
            {
                v.Draw(h);
            }
            foreach (Edge e in Edges)
            {
                e.Draw(h);
            }
        }

        public List<string> View(System.Windows.Forms.ListBox A)
        {
            List<string> t = new List<string>();
            string b;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                b = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    b += matrix[i, j];
                    b += " ";
                }
                t.Add(b);
                A.Items.Add(b);
            }
            return t;
        }

        public void Color()
        {
            int n = Vertices.Count;
            int[] colors = new int[n];
            for (int i = 0; i < n; i++)
            {
                colors[i] = -1;
            }
            colors[0] = 0;
            bool[] lc = new bool[n];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    lc[j] = false;
                }
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] != 0)
                    {
                        if (colors[j] != -1)//nu am culoare setata
                        {
                            lc[colors[j]] = true;
                        }
                    }
                }
                int idx = 0;
                while (lc[idx])//gasim primul fals
                {
                    idx++;
                }
                colors[i] = idx;
            }
            /*string t = "";
            for (int i = 0; i < n; i++)
            {
                t += colors[i];
                t += " ";
            }
            return t;*/
            for (int i = 0; i < n; i++)
            {
                Vertices[i].color = colors[i];
            }
        }

        public List<int> BFS(int nodStart)
        {
            List<int> toReturn = new List<int>();
            Queue A = new Queue();
            bool[] visited = new bool[Vertices.Count];
            visited[nodStart] = true;
            A.Push(nodStart);
            while (!A.IsEmpty())
            {
                int x = A.Pop();
                toReturn.Add(x);
                visited[x] = true;
                for (int i = 0; i < Vertices.Count; i++)
                {
                    if (matrix[x, i] != 0 && !visited[i])
                    {
                        visited[i] = true;
                        A.Push(i);
                    }
                }
            }
            return toReturn;
        }

        public List<int> DFS(int nodStart)
        {
            toR = new List<int>();
            bool[] visited = new bool[Vertices.Count];
            visited[nodStart] = true;
            DFS_Utils(nodStart, visited);
            return toR;
        }

        public void DFS_Utils(int nodStart, bool[]visited)
        {
            toR.Add(nodStart);
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (matrix[nodStart, i] != 0 && !visited[i])
                {
                    visited[i] = true;
                    DFS_Utils(i, visited);
                }
            }
        }
    }
}