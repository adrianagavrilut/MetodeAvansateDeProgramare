using System.Drawing;

namespace _13C_01_19
{
    public class Circle
    {
        public PointD center;
        public const double radius = 50;

        public Circle()
        {

        }

        public Circle(double x, double y)
        {
            center = new PointD(x, y);
        }

        public Circle(PointD center)
        {
            this.center = center;
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, (int)(center.x - radius), (int)(center.y - radius), (int)radius * 2 + 1, (int)radius * 2 + 1);
        }
    }


    public class Solution
    {
        public Circle[] circles;

        public Solution()        
        {
            circles = new Circle[5];
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle();
                circles[i].center = new PointD(Engine.rnd.Next(Engine.pictureBox.Width), Engine.rnd.Next(Engine.pictureBox.Height));
            }
        }

        public void DrawSolution(Graphics g)
        {
            for (int i = 0; i < circles.Length; i++)
                circles[i].Draw(g);
        }

        public int CountPoints()
        {
            int s = 0;
            for (int i = 0; i < Engine.points.Count; i++)
                Engine.points[i].visited = false;
            for (int i = 0; i < Engine.points.Count; i++)
            {
                for (int j = 0; j < circles.Length; j++)
                {
                    if (Engine.Distance(circles[j].center, Engine.points[i]) <= Circle.radius)
                    {
                        s++;
                        Engine.points[i].visited = true;
                        break;
                    }
                }
            }
            return s;
        }
    }
}
