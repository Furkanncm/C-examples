namespace Clicker
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


        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label1.Text="1000";
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text="";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Text="250";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text="";
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label1.Text="500";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text="";
        }
        int mora = 0, hit = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            mora++;
            label2.Text=Convert.ToString(mora);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            mora+=hit;
            label2.Text=Convert.ToString(mora);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mora>Convert.ToInt16(label1.Text))
            {
                hit=200;
                mora-=Convert.ToInt16(label1.Text);
                MessageBox.Show("Tebrikler,Yaprak kesisinin ýþýðý kýlýcýný kazandýnýz");
            }
            else
            {
                MessageBox.Show("Yeterli moraya sahip deðilsiniz");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (mora>Convert.ToInt16(label1.Text))
            {
                hit=50;
                mora-=Convert.ToInt16(label1.Text);
                MessageBox.Show("Tebrikler,5 yýldýzlý yadigar kazandýnýz");
            }
            else
            {
                MessageBox.Show("Yeterli moraya sahip deðilsiniz");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mora>Convert.ToInt16(label1.Text))
            {
                hit=50;
                mora-=Convert.ToInt16(label1.Text);
                MessageBox.Show("Tebrikler,5 yýldýzlý yadigar kazandýnýz");
            }
            else
            {
                MessageBox.Show("Yeterli moraya sahip deðilsiniz");
            }
        }
    }
}