using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _02C_10_13
{
    public class Edge
    {
        Vertex start;
        Vertex end;

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
