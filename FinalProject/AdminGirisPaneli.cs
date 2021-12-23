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
    public partial class AdminGirisPaneli : Form
    {
        public AdminGirisPaneli()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminGiris ag = new AdminGiris();
            ag.Show();
                this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAracIslem_Click(object sender, EventArgs e)
        {
            /*Aracİslemleri ai = new Aracİslemleri();
            ai.Show();

            this.Hide();*/
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            AracKiralama ak = new AracKiralama();
            ak.Show();
            this.Hide();
        }

        private void btnMuüsteriİslem_Click(object sender, EventArgs e)
        {
            /*Musteriislemleri mi = new Musteriislemleri();
            mi.Show();
            this.Hide();*/
        }

        private void btnAracSat_Click(object sender, EventArgs e)
        {
            AracSatisİslemi asi = new AracSatisİslemi();
            asi.Show();
            this.Hide();
        }
    }
}
