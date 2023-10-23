namespace AimGelistirme
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
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.FromArgb(255, 255, 192);
            pictureBox1.BackgroundImage=(Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout=ImageLayout.Stretch;
            pictureBox1.Location=new Point(422, 250);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(56, 50);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.MouseDown+=pictureBox1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=SystemColors.ControlText;
            label1.Font=new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(49, 100);
            label1.Name="label1";
            label1.Size=new Size(65, 28);
            label1.TabIndex=1;
            label1.Text="Skor:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=SystemColors.ControlText;
            label2.Font=new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(48, 31);
            label2.Name="label2";
            label2.Size=new Size(66, 28);
            label2.TabIndex=2;
            label2.Text="Süre:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=SystemColors.ControlText;
            label3.Font=new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(49, 168);
            label3.Name="label3";
            label3.Size=new Size(65, 28);
            label3.TabIndex=3;
            label3.Text="Hata:";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.BackColor=Color.Black;
            label4.Font=new Font("Segoe UI Variable Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=SystemColors.Control;
            label4.Location=new Point(138, 31);
            label4.Name="label4";
            label4.Size=new Size(27, 31);
            label4.TabIndex=4;
            label4.Text="0";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.BackColor=Color.Black;
            label5.Font=new Font("Segoe UI Variable Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor=SystemColors.Control;
            label5.Location=new Point(138, 97);
            label5.Name="label5";
            label5.Size=new Size(27, 31);
            label5.TabIndex=5;
            label5.Text="0";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.BackColor=Color.Black;
            label6.Font=new Font("Segoe UI Variable Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor=SystemColors.Control;
            label6.Location=new Point(138, 165);
            label6.Name="label6";
            label6.Size=new Size(27, 31);
            label6.TabIndex=6;
            label6.Text="0";
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(9F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(159, 159, 159);
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(880, 553);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font=new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor=SystemColors.Control;
            FormBorderStyle=FormBorderStyle.None;
            Name="Form1";
            Text="Form1";
            MouseClick+=Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}