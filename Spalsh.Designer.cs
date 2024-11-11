namespace Pet_Shop_Management_System
{
    partial class Spalsh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spalsh));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Myprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            label2 = new Label();
            PercentageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 5;
            guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(135, 25);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "Pet Shop Management";
            // 
            // Myprogress
            // 
            Myprogress.BorderRadius = 7;
            Myprogress.CustomizableEdges = customizableEdges1;
            Myprogress.Location = new Point(111, 244);
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.DeepSkyBlue;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Myprogress.Size = new Size(300, 18);
            Myprogress.TabIndex = 2;
            Myprogress.Text = "guna2ProgressBar1";
            Myprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(217, 222);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 3;
            label2.Text = "Loading...";
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.BackColor = Color.SkyBlue;
            PercentageLbl.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PercentageLbl.ForeColor = SystemColors.MenuHighlight;
            PercentageLbl.Location = new Point(244, 137);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(48, 25);
            PercentageLbl.TabIndex = 4;
            PercentageLbl.Text = "%%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Spalsh
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(497, 277);
            Controls.Add(PercentageLbl);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Spalsh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar Myprogress;
        private Label label2;
        private Label PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
