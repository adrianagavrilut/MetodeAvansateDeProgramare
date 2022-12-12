
namespace _08C_11_24
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonBFS = new System.Windows.Forms.Button();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.buttonHamilton = new System.Windows.Forms.Button();
            this.buttonCycleD = new System.Windows.Forms.Button();
            this.buttonACM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(683, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 228);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(683, 294);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 196);
            this.listBox2.TabIndex = 2;
            // 
            // buttonBFS
            // 
            this.buttonBFS.Location = new System.Drawing.Point(683, 258);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(75, 30);
            this.buttonBFS.TabIndex = 3;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.Click += new System.EventHandler(this.buttonBFS_Click);
            // 
            // buttonDFS
            // 
            this.buttonDFS.Location = new System.Drawing.Point(764, 258);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(70, 30);
            this.buttonDFS.TabIndex = 4;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.Click += new System.EventHandler(this.buttonDFS_Click);
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Location = new System.Drawing.Point(840, 258);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(75, 30);
            this.buttonDijkstra.TabIndex = 5;
            this.buttonDijkstra.Text = "Dijkstra ";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // buttonHamilton
            // 
            this.buttonHamilton.Location = new System.Drawing.Point(921, 258);
            this.buttonHamilton.Name = "buttonHamilton";
            this.buttonHamilton.Size = new System.Drawing.Size(70, 30);
            this.buttonHamilton.TabIndex = 6;
            this.buttonHamilton.Text = "drumHamilton";
            this.buttonHamilton.UseVisualStyleBackColor = true;
            this.buttonHamilton.Click += new System.EventHandler(this.buttonHamilton_Click);
            // 
            // buttonCycleD
            // 
            this.buttonCycleD.Location = new System.Drawing.Point(920, 294);
            this.buttonCycleD.Name = "buttonCycleD";
            this.buttonCycleD.Size = new System.Drawing.Size(70, 30);
            this.buttonCycleD.TabIndex = 7;
            this.buttonCycleD.Text = "Cycle Det";
            this.buttonCycleD.UseVisualStyleBackColor = true;
            this.buttonCycleD.Click += new System.EventHandler(this.buttonCycleD_Click);
            // 
            // buttonACM
            // 
            this.buttonACM.Location = new System.Drawing.Point(921, 330);
            this.buttonACM.Name = "buttonACM";
            this.buttonACM.Size = new System.Drawing.Size(75, 30);
            this.buttonACM.TabIndex = 8;
            this.buttonACM.Text = "ACM";
            this.buttonACM.UseVisualStyleBackColor = true;
            this.buttonACM.Click += new System.EventHandler(this.buttonACM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 505);
            this.Controls.Add(this.buttonACM);
            this.Controls.Add(this.buttonCycleD);
            this.Controls.Add(this.buttonHamilton);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.Button buttonDFS;
        private System.Windows.Forms.Button buttonDijkstra;
        private System.Windows.Forms.Button buttonHamilton;
        private System.Windows.Forms.Button buttonCycleD;
        private System.Windows.Forms.Button buttonACM;
    }
}

