using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _03C_10_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //to do: trebuie mmodificata matricea de adiacenta ca nodurile cu mai multe legaturi sa apara primele

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            Engine.demo = new Graph();
            Engine.demo.LoadFromFile(@"../../TextFile1.txt");
            Engine.demo.Color();
            Engine.demo.View(listBox2);
            Engine.demo.Draw(Engine.grp);
            Engine.Refresh();
        }
    }
}
