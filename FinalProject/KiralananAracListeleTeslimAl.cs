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
    public partial class KiralananAracListeleTeslimAl : Form
    {
        public KiralananAracListeleTeslimAl()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLKİRALIKARAC2TableAdapter ds = new DataSet1TableAdapters.TBLKİRALIKARAC2TableAdapter();
        ARACKİRALAMADBEntities1 db = new ARACKİRALAMADBEntities1();
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AracKiralama ak = new AracKiralama();
            ak.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.KiralıkListele();
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var ktgr = db.TBLKİRALIKARAC.Find(x);
            ktgr.DURUM = bool.Parse(txtDurum.Text);
            db.SaveChanges();
            MessageBox.Show("Araç Teslim Alındı...", "Bilgi", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }
    }
}
