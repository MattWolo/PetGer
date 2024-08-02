using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt2
{
    public partial class frmZwierzeta : Form
    {
        public frmZwierzeta()
        {
            InitializeComponent();
        }

        public static string FilterZwierzeta = "";

        private void frmZwierzeta_DoubleClick(object sender, EventArgs e)
        {
            //Ogólna funkcja przypisana do wszystkich kategorii by otworzyć frmBaza
            frmBazaZwierzeta frmBazaZwierzeta = new frmBazaZwierzeta();
            frmBazaZwierzeta.FormBorderStyle = FormBorderStyle.Sizable;
            frmBazaZwierzeta.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Koszatniczki";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Szynszyle";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Pająki";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Szczury";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Kawie domowe";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Węże";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Myszy";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Króliki";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Jaszczurki";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Myszoskoczki";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Jeże";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Żółwie";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Chomiki";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Papużki";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FilterZwierzeta = "Rybki";
        }
    }
}
