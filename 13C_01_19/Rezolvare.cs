using System.Collections.Generic;
using System.Drawing;

namespace _13C_01_19
{
    public class Rezolvare
    {
        public List<Solution> solutions;

        public Rezolvare()
        {
            solutions = new List<Solution>();
        }

        public void Init()
        {
            for (int i = 0; i < 2000; i++)
            {
                solutions.Add(new Solution());
            }
        }

        public void Sort()
        {
            solutions.Sort(delegate (Solution A, Solution B) { return B.CountPoints().CompareTo(A.CountPoints()); });
        }

        public void Draw(Graphics g)
        {
            solutions[0].DrawSolution(g);
        }
    }
}
