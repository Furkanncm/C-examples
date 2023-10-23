namespace TasKagitMakas
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
            tas=new Button();
            button3=new Button();
            button1=new Button();
            makas=new Button();
            kagit=new Button();
            button2=new Button();
            label1=new Label();
            label2=new Label();
            SuspendLayout();
            // 
            // tas
            // 
            tas.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tas.Location=new Point(191, 104);
            tas.Name="tas";
            tas.Size=new Size(178, 62);
            tas.TabIndex=5;
            tas.Text="TAŞ";
            tas.UseVisualStyleBackColor=true;
            tas.Click+=tas_Click;
            // 
            // button3
            // 
            button3.Enabled=false;
            button3.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location=new Point(522, 298);
            button3.Name="button3";
            button3.Size=new Size(185, 62);
            button3.TabIndex=6;
            button3.Text="MAKAS";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button1_Click;
            // 
            // button1
            // 
            button1.Enabled=false;
            button1.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(522, 104);
            button1.Name="button1";
            button1.Size=new Size(185, 62);
            button1.TabIndex=7;
            button1.Text="TAŞ";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button2_Click;
            // 
            // makas
            // 
            makas.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            makas.Location=new Point(191, 298);
            makas.Name="makas";
            makas.Size=new Size(178, 62);
            makas.TabIndex=8;
            makas.Text="MAKAS";
            makas.UseVisualStyleBackColor=true;
            makas.Click+=makas_Click;
            // 
            // kagit
            // 
            kagit.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            kagit.Location=new Point(191, 196);
            kagit.Name="kagit";
            kagit.Size=new Size(178, 62);
            kagit.TabIndex=9;
            kagit.Text="KAĞIT";
            kagit.UseVisualStyleBackColor=true;
            kagit.Click+=kagit_Click;
            // 
            // button2
            // 
            button2.Enabled=false;
            button2.Font=new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(522, 196);
            button2.Name="button2";
            button2.Size=new Size(185, 62);
            button2.TabIndex=10;
            button2.Text="KAĞIT";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button6_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Enabled=false;
            label1.Font=new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(828, 35);
            label1.Name="label1";
            label1.Size=new Size(0, 62);
            label1.TabIndex=11;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(936, 145);
            label2.Name="label2";
            label2.Size=new Size(0, 38);
            label2.TabIndex=12;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1464, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(kagit);
            Controls.Add(makas);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(tas);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tas;
        private Button button3;
        private Button button1;
        private Button makas;
        private Button kagit;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}