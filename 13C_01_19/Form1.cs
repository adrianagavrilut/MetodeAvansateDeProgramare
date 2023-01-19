using System;
using System.Windows.Forms;

namespace _13C_01_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            Engine.InitPoints();
            Solution solution = new Solution();
            solution.DrawSolution(Engine.grp);
            label1.Text = solution.CountPoints().ToString();
            Engine.DrawPointsList();

            Rezolvare test = new Rezolvare();
            test.Init();
            test.Sort();
            test.Draw(Engine.grp);
            Engine.Refresh();
        }
    }
}
