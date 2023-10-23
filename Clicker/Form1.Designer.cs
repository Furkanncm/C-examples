namespace Clicker
{
    partial class Form1
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1=new Panel();
            pictureBox4=new PictureBox();
            pictureBox3=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox1=new PictureBox();
            label1=new Label();
            pictureBox5=new PictureBox();
            pictureBox6=new PictureBox();
            timer1=new System.Windows.Forms.Timer(components);
            label2=new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=Color.SandyBrown;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location=new Point(651, -2);
            panel1.Name="panel1";
            panel1.Size=new Size(220, 500);
            panel1.TabIndex=0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image=(Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location=new Point(66, 359);
            pictureBox4.Name="pictureBox4";
            pictureBox4.Size=new Size(101, 90);
            pictureBox4.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex=2;
            pictureBox4.TabStop=false;
            pictureBox4.Click+=pictureBox4_Click;
            pictureBox4.MouseLeave+=pictureBox4_MouseLeave;
            pictureBox4.MouseHover+=pictureBox4_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(66, 206);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(101, 73);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=1;
            pictureBox3.TabStop=false;
            pictureBox3.Click+=pictureBox3_Click;
            pictureBox3.MouseLeave+=pictureBox3_MouseLeave;
            pictureBox3.MouseHover+=pictureBox3_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(66, 39);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(101, 103);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=0;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            pictureBox2.MouseLeave+=pictureBox2_MouseLeave;
            pictureBox2.MouseHover+=pictureBox2_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(222, 115);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(228, 355);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font=new Font("Segoe UI", 9F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.Location=new Point(502, 64);
            label1.Name="label1";
            label1.Size=new Size(100, 23);
            label1.TabIndex=7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image=(Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location=new Point(547, 57);
            pictureBox5.Name="pictureBox5";
            pictureBox5.Size=new Size(33, 36);
            pictureBox5.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex=4;
            pictureBox5.TabStop=false;
            pictureBox5.Click+=pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image=(Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location=new Point(107, 51);
            pictureBox6.Name="pictureBox6";
            pictureBox6.Size=new Size(33, 36);
            pictureBox6.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex=6;
            pictureBox6.TabStop=false;
            // 
            // timer1
            // 
            timer1.Interval=500;
            timer1.Tick+=timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(47, 57);
            label2.Name="label2";
            label2.Size=new Size(23, 28);
            label2.TabIndex=8;
            label2.Text="0";
            label2.Click+=label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.BurlyWood;
            ClientSize=new Size(870, 500);
            Controls.Add(label2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Location=new Point(650, 0);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}