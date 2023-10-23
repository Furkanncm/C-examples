namespace DijitalSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToString("HH:mm");
            label2.Text=DateTime.Now.ToString("ss");
            label3.Text=DateTime.Now.ToString("dd.MM.yyyy");
            label4.Text=DateTime.Now.ToString("dddd");
            label2.Location=new Point(label1.Location.X+label1.Width, label2.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool formtasiniyor = false;
        Point baslangicnoktasi = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formtasiniyor=true;
            baslangicnoktasi= new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formtasiniyor=false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (formtasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location= new Point(p.X-this.baslangicnoktasi.X, p.Y-this.baslangicnoktasi.Y);
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState=FormWindowState.Normal;
            }
            else if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState=FormWindowState.Maximized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int a = 0, b = 0, c = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a++; b++; c++;

            label1.BackColor=Color.FromArgb(159-a, 159-b, 159-c);
            label1.ForeColor=Color.FromArgb(37+a, 37+b, 37+c);

            label2.BackColor=Color.FromArgb(159-a, 159-b, 159-c);
            label2.ForeColor=Color.FromArgb(37+a, 37+b, 37+c);

            label3.BackColor=Color.FromArgb(159-a, 159-b, 159-c);
            label3.ForeColor=Color.FromArgb(37+a, 37+b, 37+c);

            label4.BackColor=Color.FromArgb(159-a, 159-b, 159-c);
            label4.ForeColor=Color.FromArgb(37+a, 37+b, 37+c);

            this.BackColor=Color.FromArgb(159-a, 159-b, 159-c);
            panel1.BackColor=Color.FromArgb(159-a, 159-b, 159-c);

            if (label1.BackColor==Color.FromArgb(37, 37, 37))
            {
                timer2.Stop();
                a=0; b=0; c=0;

            }
            pictureBox2.Enabled=false;
            pictureBox3.Enabled=true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            a++; b++; c++;

            label1.BackColor=Color.FromArgb(37+a, 37+b, 37+c);
            label1.ForeColor=Color.FromArgb(159-a, 159-b, 159-c);

            label2.BackColor=Color.FromArgb(37+a, 37+b, 37+c);
            label2.ForeColor=Color.FromArgb(159-a, 159-b, 159-c);

            label3.BackColor=Color.FromArgb(37+a, 37+b, 37+c);
            label3.ForeColor=Color.FromArgb(159-a, 159-b, 159-c);

            label4.BackColor=Color.FromArgb(37+a, 37+b, 37+c);
            label4.ForeColor=Color.FromArgb(159-a, 159-b, 159-c);

            this.BackColor=Color.FromArgb(37+a, 37+b, 37+c);
            panel1.BackColor=Color.FromArgb(37+a, 37+b, 37+c);

            if (label1.BackColor==Color.FromArgb(159, 159, 159))
            {
                timer3.Stop();
                a=0; b=0; c=0;

            }
            pictureBox2.Enabled=true;
            pictureBox3.Enabled=false;
        }
    }
}