using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1TüpGaz
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tuş8_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Show();
            this.Hide();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=ACR-PC\SQLEXPRESS02;Initial Catalog=TüpGazz;Integrated Security=True");
        private void tuş7_Click(object sender, EventArgs e)
        {
          
            baglan.Open();
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                SqlCommand komut = new SqlCommand("insert into k_tablosu (Ad_Soyad,Telefon,Adres,Mail_Adresi,Şifre) values  ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
                Form5 af = new Form5();
                af.Show();
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
