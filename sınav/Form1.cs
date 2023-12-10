using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        bool durdumu = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.Hour.ToString();
            label2.Text=DateTime.Now.Minute.ToString();
            label3.Text=DateTime.Now.Second.ToString();

            DateTime tarih = dateTimePicker1.Value;

            if (tarih.Hour==DateTime.Now.Hour&&
                tarih.Minute==DateTime.Now.Minute&&
                tarih.Second==DateTime.Now.Second)
            {
                
                    Thread thread = new Thread(() =>
                    {
                        panel2.BackColor=panel1.BackColor;
                        Thread.Sleep(1000);
                        panel1.BackColor = Color.Gray;
                        Thread.Sleep(1000);
                        panel1.BackColor=panel2.BackColor;


                    });
                    thread.Start();
                }
               
            }


        

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Pink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Purple;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown;
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm kuruldu");
            

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Gray;
            durdumu=true;
        }
    }
}

