using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12C_ConwayGameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int[,] matrix;
        public static int n;
        public static int m;
        public static Random rnd;
        public static List<PictureBox> livingbeings = new List<PictureBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            panelGame.Width = this.Width;
            panelGame.Height = this.Height;
            Initialize();
            GenerateMatrix();
            DrawMatrix();
            //this.Refresh();
        }

        private void DrawMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        PictureBox pctBoxAlive = new PictureBox
                        {
                            Parent = panelGame,
                            BackColor = Color.LightGreen,
                            Size = new Size(30, 30),
                            Location = new Point(j * 30, i * 30)
                        };
                        panelGame.Controls.Add(pctBoxAlive);
                        livingbeings.Add(pctBoxAlive);
                    }
                    else if (matrix[i, j] == 0)
                    {
                        PictureBox pctBoxDead = new PictureBox
                        {
                            Parent = panelGame,
                            BackColor = Color.Black,
                            Size = new Size(30, 30),
                            Location = new Point(j * 30, i * 30)
                        };
                        panelGame.Controls.Add(pctBoxDead);
                    }
                }
            }
        }

        private void GenerateMatrix()
        {
            matrix = ReadMatrixFile(@"..\..\TextFile1.txt");
        }

        private int[,] ReadMatrixFile(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            List<string> lines = new List<string>();
            string line;
            while ((line = load.ReadLine()) != null)
                lines.Add(line);
            load.Close();
            n = lines.Count;
            m = lines[0].Split(' ').Length;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = lines[i].Split(' ');
                for (int j = 0; j < m; j++)
                    a[i, j] = int.Parse(buffer[j]);
            }
            return a;
        }

        private void Initialize()
        {
            bitmap = new Bitmap(panelGame.Width, panelGame.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Live();
            panelGame.Controls.Clear();
            //panelGame.BackgroundImage = bitmap;
            foreach (var item in livingbeings)
            {
                item.Visible = false;
            }
            //this.Refresh();
            DrawMatrix();
        }

        private void Live()
        {
            int[,] matrIntermed = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int s = 0;

                    if (i - 1 >= 0 && j - 1 >= 0)
                        if (matrix[i - 1, j - 1] == 1)
                            s++;
                    if (i - 1 >= 0)
                        if (matrix[i - 1, j] == 1)
                            s++;
                    if (i - 1 >= 0 && j + 1 < m)
                        if (matrix[i - 1, j + 1] == 1)
                            s++;
                    if (j + 1 < m)
                        if (matrix[i, j + 1] == 1)
                            s++;
                    if (j + 1 < m && i + 1 < n)
                        if (matrix[i + 1, j + 1] == 1)
                            s++;
                    if (i + 1 < n)
                        if (matrix[i + 1, j] == 1)
                            s++;
                    if (i + 1 < n && j - 1 >= 0)
                        if (matrix[i + 1, j - 1] == 1)
                            s++;
                    if (j - 1 >= 0)
                        if (matrix[i, j - 1] == 1)
                            s++;

                    if (s < 2)
                        matrIntermed[i, j] = 0;
                    else if (s == 2 || s == 3)
                        matrIntermed[i, j] = 1;
                    else if (s > 3)
                        matrIntermed[i, j] = 0;
                }
            }
            matrix = matrIntermed;
        }
    }
}
