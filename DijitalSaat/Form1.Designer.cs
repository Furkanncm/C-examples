namespace DijitalSaat
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            panel1=new Panel();
            pictureBox2=new PictureBox();
            pictureBox1=new PictureBox();
            pictureBox3=new PictureBox();
            timer2=new System.Windows.Forms.Timer(components);
            timer3=new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.None;
            label1.AutoSize=true;
            label1.BackColor=Color.FromArgb(159, 159, 159);
            label1.Font=new Font("Felix Titling", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=Color.FromArgb(37, 37, 37);
            label1.Location=new Point(158, 104);
            label1.Name="label1";
            label1.Size=new Size(221, 70);
            label1.TabIndex=0;
            label1.Text="label1";
            // 
            // label2
            // 
            label2.Anchor=AnchorStyles.None;
            label2.AutoSize=true;
            label2.BackColor=Color.FromArgb(159, 159, 159);
            label2.Font=new Font("Felix Titling", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=Color.FromArgb(37, 37, 37);
            label2.Location=new Point(385, 132);
            label2.Name="label2";
            label2.Size=new Size(117, 35);
            label2.TabIndex=1;
            label2.Text="label2";
            // 
            // label3
            // 
            label3.Anchor=AnchorStyles.None;
            label3.AutoSize=true;
            label3.BackColor=Color.FromArgb(159, 159, 159);
            label3.Font=new Font("Felix Titling", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor=Color.FromArgb(37, 37, 37);
            label3.Location=new Point(158, 220);
            label3.Name="label3";
            label3.Size=new Size(239, 70);
            label3.TabIndex=2;
            label3.Text="label3";
            // 
            // label4
            // 
            label4.Anchor=AnchorStyles.None;
            label4.AutoSize=true;
            label4.BackColor=Color.FromArgb(159, 159, 159);
            label4.Font=new Font("Felix Titling", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor=Color.FromArgb(37, 37, 37);
            label4.Location=new Point(477, 220);
            label4.Name="label4";
            label4.Size=new Size(238, 70);
            label4.TabIndex=3;
            label4.Text="label4";
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // panel1
            // 
            panel1.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(800, 35);
            panel1.TabIndex=4;
            panel1.DoubleClick+=panel1_DoubleClick;
            panel1.MouseDown+=panel1_MouseDown;
            panel1.MouseMove+=panel1_MouseMove;
            panel1.MouseUp+=panel1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor=Color.Black;
            pictureBox2.Location=new Point(40, 0);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(35, 35);
            pictureBox2.TabIndex=0;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.Red;
            pictureBox1.Location=new Point(0, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(35, 35);
            pictureBox1.TabIndex=5;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor=SystemColors.Control;
            pictureBox3.Location=new Point(80, 0);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(35, 35);
            pictureBox3.TabIndex=6;
            pictureBox3.TabStop=false;
            pictureBox3.Click+=pictureBox3_Click;
            // 
            // timer2
            // 
            timer2.Interval=10;
            timer2.Tick+=timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval=10;
            timer3.Tick+=timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ControlDark;
            ClientSize=new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.None;
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}