using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _06C_11_10
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
            Engine.demo.Color();
            Engine.demo.View(listBox2);
            Engine.demo.Draw(Engine.grp);
            Engine.Refresh();
        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            List<int> t = Engine.demo.BFS(3);
            string x = "";
            foreach (int i in t)
            {
                x += i + " ";
            }
            listBox1.Items.Add(x);
        }

        private void buttonDFS_Click(object sender, EventArgs e)
        {
            List<int> t = Engine.demo.DFS(3);
            string x = "";
            foreach (int i in t)
            {
                x += i + " ";
            }
            listBox1.Items.Add(x);
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            int nodStart = 1;
            float[] t = Engine.demo.Dijkstra(nodStart);
            for (int i = 0; i < Engine.demo.Vertices.Count; i++)
                listBox1.Items.Add(nodStart + " --> " + i + ":  " + t[i]);
        }

        private void buttonHamilton_Click(object sender, EventArgs e)
        {
            int nodStart = 1;
            string s = "";
            int[] t = Engine.demo.Hamilton(nodStart);
            for (int i = 0; i < Engine.demo.Vertices.Count; i++)
                s += t[i] + " ";
            listBox1.Items.Add(s);
        }
    }
}
