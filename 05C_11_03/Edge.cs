using System.Drawing;

namespace _05C_11_03
{
    public class Edge
    {
        public Vertex start;
        public Vertex end;

        public Edge(string data)
        {
            string[] buffer = data.Split(' ');
            start = Engine.Search(buffer[0], Engine.demo);
            end = Engine.Search(buffer[1], Engine.demo);
        }

        public void Draw(Graphics h)
        {
            h.DrawLine(Pens.Red, start.location, end.location);
        }
    }
}
