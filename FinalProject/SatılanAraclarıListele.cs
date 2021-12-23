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
    public partial class SatılanAraclarıListele : Form
    {
        public SatılanAraclarıListele()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLSATILIKARAC1TableAdapter ds = new DataSet1TableAdapters.TBLSATILIKARAC1TableAdapter();

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AracSatisİslemi asi = new AracSatisİslemi();
            asi.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SatılanAracGoruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }
    }
}
