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


namespace FinalProject
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-847PRS4\\SQLEXPRESS;Initial Catalog=ARACKİRALAMADB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text==textBox3.Text)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Insert into TBLADMİN values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", con);
                command.Parameters.AddWithValue("@p1", tctKullaniciAd.Text);
                command.Parameters.AddWithValue("@p2", txtSifre.Text);
                command.Parameters.AddWithValue("@p3", txtAd.Text);
                command.Parameters.AddWithValue("@p4", txtSoyad.Text);
                command.Parameters.AddWithValue("@p5", txtYas.Text);
                command.Parameters.AddWithValue("@p6", txtCinsiyet.Text);
                command.Parameters.AddWithValue("@p7", txtMaas.Text);
                command.Parameters.AddWithValue("@p8", txtGorev.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Üye kaydedildi...");
                con.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreler Uyuşmuyor...");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
