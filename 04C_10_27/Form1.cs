using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04C_10_27
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
            //Engine.demo.Draw(Engine.grp);
            Engine.demo.Color();

            List<string> t = Engine.demo.View(listBox2);
            Engine.demo.Draw(Engine.grp);
            //foreach (string s in t)
            //{
            //    listBox1.Items.Add(s);
            //}
            //listBox1.Items.Add(Engine.demo.Color());

            Engine.Refresh();
        }
    }
}
