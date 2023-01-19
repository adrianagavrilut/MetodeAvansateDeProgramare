using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace _02C_10_13
{
    public class Graph
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;

        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader load = new StreamReader(filename);
            int n = int.Parse(load.ReadLine());
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = load.ReadLine();
                Vertex local = new Vertex(buffer);
                Vertices.Add(local);
            }
            while ((buffer = load.ReadLine()) != null)
            {
                Edge edge = new Edge(buffer);
                Edges.Add(edge);
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
    }


}
