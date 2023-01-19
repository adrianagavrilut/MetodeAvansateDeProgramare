﻿using System.Drawing;

namespace _06C_11_10
{
    public class Vertex
    {
        public string name;
        public PointF location;
        public int idx;
        public int color = 0;
        static int size = 11;

        public Vertex(string name, PointF location)
        {
            this.name = name;
            this.location = location;
            idx = -1;
        }

        public Vertex(string data)
        {
            string[] t = data.Split(' ');
            name = t[0].Trim();
            location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
        }

        public void Draw(Graphics h)
        {
            h.FillEllipse(new SolidBrush(Engine.pall[color]), location.X - size, location.Y - size, 2 * size + 1, 2 * size + 1);
            h.DrawEllipse(Pens.Black, location.X - size, location.Y - size, 2 * size + 1, 2 * size + 1);
            h.DrawString(name, new Font("Arial", 14, FontStyle.Regular), new SolidBrush(Color.Black), location.X, location.Y);
        }

    }
}
