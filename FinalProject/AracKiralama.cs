using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AracKiralama : Form
    {
        public AracKiralama()
        {
            InitializeComponent();
        }
        void hesapla()
        {
            TimeSpan fark = Convert.ToDateTime(dateTimePicker1.Text) - Convert.ToDateTime(dateTimePicker2.Text);
            label6.Text = fark.Days.ToString()+" Gün";

            int a = fark.Days;
            int b = Convert.ToInt32(txtFiyat.Text);

            int tutar = a * b;

            textBox3.Text = tutar.ToString()+" TL";
            
        }
        
        void temizle()
        {
            txtAdSoyad.Text = "";
            txtTc.Text = "";
           textBox2.Text = "";
            txtEhno.Text = "";
            dateTimePicker1.Text = "";

            dateTimePicker2.Text = "";
            textBox3.Text = "";
            label6.Text = "";
        }
        DataSet1TableAdapters.TBLKİRALIKARAC1TableAdapter a = new DataSet1TableAdapters.TBLKİRALIKARAC1TableAdapter();
        // DataSet1TableAdapters.TBLKİRALIKARACTableAdapter kis = new DataSet1TableAdapters.TBLKİRALIKARACTableAdapter();
       ARACKİRALAMADBEntities1 dbEn = new ARACKİRALAMADBEntities1();
        
        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = dbEn.TBLKİRALIKARAC.Find(x);
            dbEn.TBLKİRALIKARAC.Remove(ktgr);
            dbEn.SaveChanges();
            MessageBox.Show("Araç Silindi...", "Bilgi", MessageBoxButtons.OK);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KiralananAracListeleTeslimAl kalt = new KiralananAracListeleTeslimAl();
            kalt.Show();
            this.Hide();
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = kis.Kiralıkİslem();
            dataGridView1.DataSource = a.Kiralikİslem();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKİRALIKARAC k = new TBLKİRALIKARAC();
            k.ARACMARKA = txtMarka.Text;
            k.ARACMODEL = txtAracModel.Text;
            k.ARACFİYAT = txtFiyat.Text;
            k.DURUM = bool.Parse( txtDurum.Text);
            k.ARACTİP = txtTip.Text;
            k.ARACRENK = txtRenk.Text;
            k.ARACYIL = txtYıl.Text;
            k.ARACMUAYENETARİH = textBox1.Text;
            k.ARACPLAKA = txtPlaka.Text;
            k.ARACVİTES = txtVites.Text;
            k.ARACRESİM = txtResim.Text;
            dbEn.TBLKİRALIKARAC.Add(k);
            dbEn.SaveChanges();
            MessageBox.Show("Araç Eklendi...", "Bilgi", MessageBoxButtons.OK);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAracModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtRenk.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYıl.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            txtTip.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtPlaka.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtVites.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            txtTc.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            txtEhno.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
           textBox2.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            txtResim.Text = dataGridView1.Rows[secilen].Cells[18].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[19].Value.ToString();

            pictureBox2.ImageLocation = dataGridView1.Rows[secilen].Cells[18].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminGirisPaneli agp = new AdminGirisPaneli();
            agp.Show();
            this.Hide();
        }
        
        private void btnKirala_Click(object sender, EventArgs e)
        {
            hesapla();
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = dbEn.TBLKİRALIKARAC.Find(x);
            ktgr.DURUM = bool.Parse( txtDurum.Text);
            ktgr.VERİLİŞTARİH = dateTimePicker2.Value.ToString("G");
            ktgr.ALIŞTARİH = dateTimePicker1.Value.ToString("G");
            ktgr.ARACFİYAT = txtFiyat.Text;
            ktgr.MUSTERİADSOYAD = txtAdSoyad.Text;
            ktgr.TC = txtTc.Text;
            ktgr.EHLİYETNO = txtEhno.Text;
            ktgr.TELNO = textBox2.Text;
            ktgr.ODENECEKUCRET = textBox3.Text;
            dbEn.SaveChanges();
            MessageBox.Show("Araç Kiralandı...", "Bilgi", MessageBoxButtons.OK);
            
           

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktg = dbEn.TBLKİRALIKARAC.Find(x);
            ktg.ARACMARKA = txtMarka.Text;
            ktg.ARACMODEL = txtAracModel.Text;
            ktg.ARACFİYAT = txtFiyat.Text;
            ktg.DURUM = bool.Parse( txtDurum.Text);
            ktg.ARACTİP = txtTip.Text;
            ktg.ARACRENK = txtRenk.Text;
            ktg.ARACYIL = txtYıl.Text;
            ktg.ARACMUAYENETARİH = textBox1.Text;
            ktg.ARACPLAKA = txtPlaka.Text;
            ktg.ARACVİTES = txtVites.Text;
            ktg.MUSTERİADSOYAD = txtAdSoyad.Text;
            ktg.TC = txtTc.Text;
            ktg.EHLİYETNO = txtEhno.Text;
            ktg.TELNO = textBox2.Text;
            ktg.VERİLİŞTARİH = (dateTimePicker2.Value.ToString("G"));
            ktg.ALIŞTARİH = ( dateTimePicker1.Value.ToString("G"));
            ktg.ARACRESİM = txtResim.Text;
            ktg.ODENECEKUCRET = textBox3.Text;
            dbEn.SaveChanges();
            MessageBox.Show("Araç Bilgileri Güncellendi...", "Bilgi", MessageBoxButtons.OK);
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }
    }
}
