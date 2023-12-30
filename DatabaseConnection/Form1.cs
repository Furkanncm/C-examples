using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL Kütüphanesi


namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-FURKAN\\FIRSTSQL;Initial Catalog=C-csDatabaseConnection;Integrated Security=True";
        SqlConnection SqlConnection = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlConnection.State == ConnectionState.Closed)
                {
                    SqlConnection.ConnectionString = constring;
                    SqlConnection.Open();

                    string sql = "INSERT INTO Bilgi (kullanici_adi,ad_soyad,telefon) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
                    SqlCommand command = new SqlCommand(sql, SqlConnection);

                    command.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
                    command.Parameters.AddWithValue("@ad_soyad", textBox3.Text);
                    command.Parameters.AddWithValue("@telefon", textBox2.Text);
                    command.ExecuteNonQuery();

                    SqlConnection.Close();
                    MessageBox.Show("Bağlantı Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
