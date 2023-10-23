namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        int kullaniciPuan = 0;
        int bilgisayarPuan = 0;


        private void tas_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
            button2.BackColor=Color.White;
            button3.BackColor=Color.White;
            Random rand = new Random();
            int deger = rand.Next(1, 4);
            switch (deger)
            {
                case 1:
                    label1.Text="Beraberlik";
                    button1.BackColor=Color.Gray;
                    break;
                case 2:
                    label1.Text="Bilgisayar Kazandi";
                    button2.BackColor=Color.Green;
                    bilgisayarPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
                case 3:
                    label1.Text=("Kullanici Kazandi");
                    button3.BackColor=Color.Red;
                    kullaniciPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
            }

        }
        private void kagit_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
            button2.BackColor=Color.White;
            button3.BackColor=Color.White;
            Random rand = new Random();
            int deger = rand.Next(1, 4);
            switch (deger)
            {
                case 1:
                    label1.Text="Kullanici Kazandi";
                    kullaniciPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
                case 2:
                    label1.Text="Beraberlik";
                    break;
                case 3:
                    label1.Text=("Bilgisayar Kazandi");
                    bilgisayarPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
            }

        }

        private void makas_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
            button2.BackColor=Color.White;
            button3.BackColor=Color.White;
            Random rand = new Random();
            int deger = rand.Next(1, 4);
            switch (deger)
            {
                case 1:
                    label1.Text="Bilgisayar Kazandi";
                    bilgisayarPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
                case 2:
                    label1.Text="Kullanici Kazandi";
                    kullaniciPuan++;
                    label2.Text=kullaniciPuan.ToString();
                    break;
                case 3:
                    label1.Text=("Beraberlik");
                    break;
            }

        }

    }
}