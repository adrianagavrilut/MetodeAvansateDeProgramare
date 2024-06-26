﻿using System.Drawing;
using System.Windows.Forms;

namespace _02C_10_13
{
    public static class Engine
    {
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox display;
        public static Color color = Color.BlanchedAlmond;
        public static Graph demo;

        public static void InitGraph(PictureBox t)
        {
            display = t;
            bmp = new Bitmap(t.Width, t.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(color);
        }

        public static void Refresh()
        {
            display.Image = bmp;
        }

        public static void Clear()
        {
            grp.Clear(color);
        }

        public static Vertex Search(string name, Graph g)
        {
            foreach (Vertex vertex in g.Vertices)
            {
                if (vertex.name == name)
                    return vertex;
            }
            return null;
        }
    }
}
