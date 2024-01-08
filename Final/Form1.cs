using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//21360859036 FURKAN KAZIM ÇAM

namespace Final
{
    public partial class Form1 : Form
    {
        private int suAnkiSayfa = 0;
        private int toplamSutun = 395;
        private int SayfadakiSutun = 8;
        public class Note
        {
            public string Day { get; set; }
            public int StartHour { get; set; }
            public int Duration { get; set; }
            public string Text { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeCalendar();
            SutunGorunurluk();
            SayfayıGuncelle();
            this.Load += AnaForm_Load;
            this.Resize += AnaForm_Resize;

        }
        private void AnaForm_Resize(object sender, EventArgs e)
        {
            // DataGridView'in boyutunu form boyutuna uyacak şekilde güncelle
            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }


        private void InitializeCalendar()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            // Haftalık ve saatlik gösterim için sütunlar eklenir
            GunYaz();
            SaatYaz();
            // DataGridView form üzerine eklenir
            this.Controls.Add(dataGridView1);
        }
        private void GunYaz()
        {
            // Haftalık sütunlar eklenir
            DateTime date = DateTime.Now;

            dataGridView1.Columns.Add("Time", "Zaman");
            dataGridView1.Columns.Add("Monday", date.ToString("dd/MM/yy/dddd"));
            for (int i = 0; i < 395; i++)
            {
                date = date.AddDays(1);
                dataGridView1.Columns.Add("Tuesday", date.ToString("dd/MM/yy/dddd"));
            }

            dataGridView1.Columns[0].ReadOnly = true; // Saat sütunu salt okunur olmalıdır
            // ekranda gösterilecek sütun sayısı ayarlanır
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;


        }

        private void SaatYaz()
        {
            // Saatlik satırlar eklenir
            for (int hour = 0; hour < 24; hour++)
            {
                dataGridView1.Rows.Add($"{hour}:00 ");
            }
            dataGridView1.Rows[0].ReadOnly = true; // Günlerin olduğu satır salt okunur olmalıdır

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor == Color.Red)
            {
                groupBox1.Visible=false;
                MessageBox.Show("Seçili hücreye not eklenemez");

            }

        }
        private void SutunGorunurluk()
        {
            // Görüntülenecek sütunları belirle
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i == 0)
                {
                    // "Saat" sütunu her zaman görünür
                    dataGridView1.Columns[i].Visible = true;
                }
                else
                {
                    // Diğer sütunları belirle
                    dataGridView1.Columns[i].Visible = ((i - 1) >= suAnkiSayfa * (SayfadakiSutun -1) && (i - 1) < (suAnkiSayfa + 1) * (SayfadakiSutun - 1));
                }
            }
        }
        private void SayfayıGuncelle()
        {
            // Önceki ve sonraki butonların durumunu güncelle
            once.Enabled = suAnkiSayfa > 0;
            sonra.Enabled = (suAnkiSayfa + 1) * SayfadakiSutun < toplamSutun;
        }


        private void once_Click(object sender, EventArgs e)
        {
            if (suAnkiSayfa > 0)
            {
                suAnkiSayfa--;
                SutunGorunurluk();
                SayfayıGuncelle();
            }

        }

        private void sonra_Click(object sender, EventArgs e)
        {
            if ((suAnkiSayfa + 1) * SayfadakiSutun < toplamSutun)
            {
                suAnkiSayfa++;
                SutunGorunurluk();
                SayfayıGuncelle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 0&& dataGridView1.CurrentCell.RowIndex!=0)
            {
                dataGridView1.CurrentCell.Value = "";
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor=Color.White;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            groupBox1.Visible = false;


        }

        string[] notes = new string[100];
        private void button5_Click(object sender, EventArgs e)
        {


            //seçili olan hücreye texti yazdırır
            if (dataGridView1.CurrentCell.ColumnIndex != 0 && dataGridView1.CurrentCell.RowIndex != 0)
            {
                dataGridView1.CurrentCell.Value = textBox1.Text;
                //textboxa eklenen texti diziye kaydet
                for (int i = 0; i < notes.Length; i++)
                {
                    notes[i] = textBox1.Text;
                }

                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor=Color.Yellow;
                //girilen saat kadar hücreyi boyar
                for (int i = 1; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + i].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor = Color.Red;

                }

            }
            else
            {
                MessageBox.Show("Seçili hücreye not eklenemez");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hücre boş değilse hücreyi günceller


            if (dataGridView1.CurrentCell.Value==null)
            {
                MessageBox.Show("Boş olan hücre güncellenemez");
            }

            if (dataGridView1.CurrentCell.ColumnIndex != 0 && dataGridView1.CurrentCell.RowIndex != 0)
            {
                dataGridView1.CurrentCell.Value = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Seçili hücre güncellenemez");

            }
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor=Color.Yellow;
            //girilen saat kadar hücreyi boyar
            for (int i = 1; i < Convert.ToInt32(textBox2.Text); i++)
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + i].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor = Color.Red;

            }


        }

        private void ara_Click(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText)) // TextBox boş değilse işleme devam et
            {
                // textboxta yazılan değeri not dizisi içinde ara
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i] == searchText)
                    {
                        // bulunan değeri listboxta göster
                        if (listBox1.Items.Contains(searchText))
                        {

                            listBox1.Items.Add(searchText);
                        }

                        MessageBox.Show("Aranan değer bulundu");

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Aranan değer bulunamadı.");

                    }
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.ToLower();
            listBox1.Items.Clear(); // ListBox'ı temizle

            if (!string.IsNullOrEmpty(searchText)) // TextBox boş değilse işleme devam et
            {
                bool found = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                        {
                            // Bulunan değeri ListBox'a ekle
                            listBox1.Items.Add($"Row: {cell.RowIndex + 1}, Column: {cell.ColumnIndex + 1}, Value: {cell.Value}");
                            found = true;
                            break; // İlk bulunan değeri gösterdikten sonra döngüden çık
                        }
                    }
                }

                if (!found)
                {
                    listBox1.Items.Add("Aranan değer bulunamadı.");
                }
            }
            else
            {
                // TextBox boşsa, ListBox'a bir mesaj ekle
                listBox1.Items.Add("Arama metni girilmelidir.");
            }
        }
    }
}

