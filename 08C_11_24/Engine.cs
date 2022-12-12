using System.Drawing;
using System.Windows.Forms;

namespace _08C_11_24
{

    public static class Engine
    {
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox display;
        public static Color color = Color.BlanchedAlmond;
        public static Graph demo;
        public static Graph ACM;
        public static Color[] pall = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Orchid };

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