namespace AimGelistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor = 0, süre = 60;
        bool furkan=false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            furkan=true;
            timer1.Start();
            Random random = new Random();       //Random random = new Random();                                   
            int x = random.Next(50, 700);        // int x = random.Next(0, this.ClientSize.Width - pictureBox1.Width);
            int y = random.Next(50, 500);        //int y = random.Next(0, this.ClientSize.Height - pictureBox1.Height);<
            pictureBox1.Location = new Point(x, y);
            skor++;
            label5.Text=skor.ToString();

        }
        int hata = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (furkan)
            {
                hata++;
                label6.Text=hata.ToString();
                if (hata==5)
                {
                    timer1.Stop();
                    MessageBox.Show($"Caniniz Kalmadi.\nSkorunuz:{skor}");
                    Application.Restart();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label4.Text=süre.ToString();
            if (süre<0)
            {
                timer1.Stop();
                MessageBox.Show($"Süre bitti.\nSkorunuz{skor}");
                Application.Restart();
            }
        }


    }
}