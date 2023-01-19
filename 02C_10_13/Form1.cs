using System;
using System.Windows.Forms;

namespace _02C_10_13
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
            Engine.demo = new Graph();
            Engine.demo.LoadFromFile(@"../../TextFile1.txt");
            Engine.demo.Draw(Engine.grp);
            Engine.Refresh();
        }
    }
}
