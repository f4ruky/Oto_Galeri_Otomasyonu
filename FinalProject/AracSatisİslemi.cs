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
    public partial class AracSatisİslemi : Form
    {
        DataSet1TableAdapters.TBLSATILIKARACTableAdapter ds = new DataSet1TableAdapters.TBLSATILIKARACTableAdapter();
        ARACKİRALAMADBEntities1 db = new ARACKİRALAMADBEntities1();
        public AracSatisİslemi()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtAdSoyad.Text = "";
            txtTC.Text = "";
            txtTelNo.Text = "";
            txtEhNo.Text = "";
            txtVerilisTarih.Text = "";
            txtid.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtFiyat.Text = "";
            txtDurum.Text = "";
            txtTip.Text = "";
            txtRenk.Text = "";
            txtYıl.Text = "";
            txtAracDurum.Text = "";
            txtPlaka.Text = "";
            txtVites.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.TBLSATILIKARAC.Find(x);
            db.TBLSATILIKARAC.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Araç Silindi...", "Bilgi", MessageBoxButtons.OK);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SatılanAraclarıListele sal = new SatılanAraclarıListele();
            sal.Show();
            this.Hide();
        }

        private void BtnListele_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Satisİslem();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminGirisPaneli agp = new AdminGirisPaneli();
            agp.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtRenk.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYıl.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAdurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtTip.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtPlaka.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtVites.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtVerilisTarih.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            txtEhNo.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            txtTelNo.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            txtAracDurum.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
           //
           //
           //
           txtResim.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();

            pictureBox2.ImageLocation= dataGridView1.Rows[secilen].Cells[17].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLSATILIKARAC s = new TBLSATILIKARAC();
            s.ARACMARKA = txtMarka.Text;
            s.ARACMODEL = txtModel.Text;
            s.ARACFİYAT = txtFiyat.Text;
            s.DURUM = bool.Parse(txtDurum.Text);
            s.ARACTİP = txtTip.Text;
            s.ARACRENK = txtRenk.Text;
            s.ARACYIL = txtYıl.Text;
            s.ARACDURUM = txtAdurum.Text;
            s.ARACPLAKA = txtPlaka.Text;
            s.ARACVİTES = txtVites.Text;
            s.ARACFİYAT = txtFiyat.Text;
            s.ARACRESİM = txtResim.Text;
            s.ARACMUAYENETARİH = txtAracDurum.Text;
            db.TBLSATILIKARAC.Add(s);
            db.SaveChanges();
            MessageBox.Show("Araç Eklendi...", "Bilgi", MessageBoxButtons.OK);

        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.TBLSATILIKARAC.Find(x);
            ktgr.DURUM = bool.Parse(txtDurum.Text);
            ktgr.SATISTARİH = txtVerilisTarih.Text;
            ktgr.MUSTERİADSOYAD = txtAdSoyad.Text;
            ktgr.TC = txtTC.Text;
            ktgr.EHLİYETNO = txtEhNo.Text;
            ktgr.TELNO = txtTelNo.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Satıldı...", "Bilgi", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtid.Text);
            var b = db.TBLSATILIKARAC.Find(a);
            b.ARACMARKA = txtMarka.Text;
            b.ARACMODEL = txtModel.Text;
            b.ARACFİYAT = txtFiyat.Text;
            b.DURUM = bool.Parse(txtDurum.Text);
            b.ARACTİP = txtTip.Text;
            b.ARACRENK = txtRenk.Text;
            b.ARACYIL = txtYıl.Text;
            b.ARACDURUM = txtAdurum
                .Text;
            b.ARACPLAKA = txtPlaka.Text;
            b.ARACVİTES = txtVites.Text;
            b.ARACFİYAT = txtFiyat.Text;
            b.SATISTARİH = txtVerilisTarih.Text;
            b.MUSTERİADSOYAD = txtAdSoyad.Text;
            b.TC = txtTC.Text;
            b.EHLİYETNO = txtEhNo.Text;
            b.TELNO = txtTelNo.Text;
            b.ARACMUAYENETARİH = txtAracDurum.Text;
            b.ARACRESİM = txtResim.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Bilgileri Güncellendi...", "Bilgi", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }
    }
}
