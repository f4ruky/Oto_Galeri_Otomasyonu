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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MusteriGiris mg = new MusteriGiris();
            mg.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiris ag = new AdminGiris();
            ag.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Adminİslemleri1 a1 = new Adminİslemleri1();
            a1.Show();
            this.Hide();
        }
    }
}
