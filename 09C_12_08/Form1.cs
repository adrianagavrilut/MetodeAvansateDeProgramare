using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _09C_12_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.LoadFromFile(@"..\..\TextFile1.txt");

            List<string> list = graph.View(graph.matrixAd);
            foreach (string s in list)
            {
                listBox1.Items.Add(s);
            }
            listBox1.Items.Add("\n");

            graph.RoyWarshall();
            List<string> list2 = graph.View(graph.matrixDr);
            foreach (string s in list2)
            {
                listBox1.Items.Add(s);
            }
            listBox1.Items.Add("\n");

            List<string> list3 = graph.CTC();
            foreach (string s in list3)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
