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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-847PRS4\\SQLEXPRESS;Initial Catalog=ARACKİRALAMADB;Integrated Security=True");
        DataSet1TableAdapters.TBLADMİNTableAdapter ds = new DataSet1TableAdapters.TBLADMİNTableAdapter();
        ARACKİRALAMADBEntities3 db = new ARACKİRALAMADBEntities3();
        
        private void Personeller_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Personel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.TBLADMİN.Find(x);
            db.TBLADMİN.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi...", "Bilgi", MessageBoxButtons.OK);*/

            ds.PersonelSil(byte.Parse( txtid.Text));
            MessageBox.Show("Personel Silindi");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtid.Text);
             var pers = db.TBLADMİN.Find(a);
             pers.KULLANİCİAD = txtKullaniciAd.Text;
             pers.SİFRE = txtSifre.Text;
             pers.PERAD = txtAd.Text;
             pers.PERSOYAD = txtSoyad.Text;
             pers.PERYAS = txtYas.Text;
             pers.PERCİNSİYET = txtCinsiyet.Text;
             pers.PERMAAS = txtMaas.Text;
             pers.PERGÖREV = txtGorev.Text;
             db.SaveChanges();
             MessageBox.Show("Personel Bilgileri Güncellendi...", "Bilgi", MessageBoxButtons.OK);
           


            // ds.PersonelGuncelle(txtKullaniciAd.Text,txtSifre.Text,txtAd.Text,txtSoyad.Text,txtCinsiyet.Text,txtMaas.Text,txtGorev.Text,byte.Parse(txtid.Text));

            //SqlCommand komut = new SqlCommand("Update TBLADMİN set (KULLANİCİ AD = @P1)");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminİslemleri1 a1 = new Adminİslemleri1();
            a1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKullaniciAd.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtCinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtGorev.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtid.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }
    }
}
