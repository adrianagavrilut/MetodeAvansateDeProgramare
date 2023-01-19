using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _13C_01_19
{
    public static class Engine
    {
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox pictureBox;
        public static Color color;
        public static List<PointD> points;
        public static Random rnd = new Random();

        public static void InitGraph(PictureBox p)
        {
            pictureBox = p;
            bmp = new Bitmap(p.Width, p.Height);
            grp = Graphics.FromImage(bmp);
        }

        public static void InitPoints()
        {
            points = new List<PointD>();
            for (int i = 1; i <= 100; i++)
                points.Add(new PointD(rnd.Next(pictureBox.Width), rnd.Next(pictureBox.Height)));
        }

        public static void DrawPointsList()
        {
            foreach (PointD p in points)
                p.Draw(grp);
            Refresh();
        }


        public static void Clear()
        {
            grp.Clear(color);
        }

        public static void Refresh()
        {
            pictureBox.Image = bmp;
        }

        public static double Distance(PointD A, PointD B)
        {
            return Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
        }
    }
}
