using System.Drawing;

namespace _02C_10_13
{
    public class Vertex
    {
        public string name;
        public PointF location;

        public Vertex(string name, PointF location)
        {
            this.name = name;
            this.location = location;
        }

        public Vertex(string data)
        {
            string[] t = data.Split(' ');
            name = t[0].Trim();
            location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
        }

        public void Draw(Graphics h)
        {
            h.DrawEllipse(Pens.Black, location.X - 5, location.Y - 5, 11, 11);
            h.DrawString(name, new Font("Arial", 12, FontStyle.Regular), new SolidBrush(Color.Blue), location.X, location.Y);
        }
    }
}
