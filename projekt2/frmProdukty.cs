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
    public partial class frmProdukty : Form
    {
        public frmProdukty()
        {
            InitializeComponent();
    }
        public static string FilterValue = "";

        private void DoubleClick_Go_Baza(object sender, EventArgs e)
        {
            //Ogólna funkcja przypisana do wszystkich kategorii by otworzyć frmBaza
            frmBaza frmBaza_op = new frmBaza();
            frmBaza_op.FormBorderStyle = FormBorderStyle.Sizable;
            frmBaza_op.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilterValue = "Karmy";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilterValue = "Przysmaki";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FilterValue = "Miski";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FilterValue = "Smycze";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FilterValue = "Obroże";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FilterValue = "Ubranka";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FilterValue = "Zabawki";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FilterValue = "Drapaki";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FilterValue = "Koce i legowiska";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FilterValue = "Kuwety";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FilterValue = "Klatki";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FilterValue = "Akwaria";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FilterValue = "Żwirki";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FilterValue = "Granulaty i ściółki";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FilterValue = "Dodatki do akwariów";
        }

        private void frmProdukty_Load(object sender, EventArgs e)
        {

        }
    }
}
