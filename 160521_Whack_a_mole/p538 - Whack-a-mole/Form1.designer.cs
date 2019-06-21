namespace p538___Whack_a_mole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.miss = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.score.Font = new System.Drawing.Font("Consolas", 24F);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(261, 46);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 37);
            this.score.TabIndex = 9;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.labelScore.Font = new System.Drawing.Font("Consolas", 24F);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(154, 46);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(107, 37);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.labelName.Font = new System.Drawing.Font("Consolas", 24F);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(154, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 37);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Miss";
            // 
            // miss
            // 
            this.miss.AutoSize = true;
            this.miss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.miss.Font = new System.Drawing.Font("Consolas", 24F);
            this.miss.ForeColor = System.Drawing.Color.White;
            this.miss.Location = new System.Drawing.Point(261, 92);
            this.miss.Name = "miss";
            this.miss.Size = new System.Drawing.Size(35, 37);
            this.miss.TabIndex = 13;
            this.miss.Text = "0";
            // 
            // display
            // 
            this.display.Tick += new System.EventHandler(this.display_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(121, 150);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(212, 10);
            this.progressBar1.TabIndex = 14;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Image = ((System.Drawing.Image)(resources.GetObject("label0.Image")));
            this.label0.Location = new System.Drawing.Point(16, 195);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(140, 154);
            this.label0.TabIndex = 15;
            this.label0.Click += new System.EventHandler(this.label0_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(161, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 154);
            this.label1.TabIndex = 16;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(306, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 154);
            this.label2.TabIndex = 17;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(16, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 154);
            this.label3.TabIndex = 18;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(161, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 154);
            this.label4.TabIndex = 19;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(306, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 154);
            this.label5.TabIndex = 20;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(16, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 154);
            this.label6.TabIndex = 21;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(161, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 154);
            this.label7.TabIndex = 22;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(306, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 154);
            this.label8.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::p538___Whack_a_mole.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(460, 757);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.miss);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Whack-a-mole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label miss;
        private System.Windows.Forms.Timer display;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

