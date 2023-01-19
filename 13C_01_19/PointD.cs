using System.Drawing;

namespace _13C_01_19
{
    public class PointD
    {
        public double x, y;
        public const int radiusPoint = 3;
        public bool visited = false;

        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public PointD()
        {

        }

        public void Draw(Graphics g)
        {
            if (!visited)
            {
                g.DrawEllipse(Pens.Black, (int)x - radiusPoint, (int)y - radiusPoint, 2 * radiusPoint + 1, 2 * radiusPoint + 1);

            }
            else
            {
                g.FillEllipse(Brushes.Red, (int)x - radiusPoint, (int)y - radiusPoint, 2 * radiusPoint + 1, 2 * radiusPoint + 1);
                g.DrawEllipse(Pens.Blue, (int)x - radiusPoint, (int)y - radiusPoint, 2 * radiusPoint + 1, 2 * radiusPoint + 1);

            }
        }
    }
}
