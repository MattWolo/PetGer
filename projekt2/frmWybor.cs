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
    public partial class frmWybor : Form
    {
        public frmWybor()
        {
            InitializeComponent();
            //wywołanie frmProdukty na początek by pusto nie było
            this.pnlWyboru.Controls.Clear();
            frmProdukty frmProdukty_op = new frmProdukty() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProdukty_op.FormBorderStyle = FormBorderStyle.None;
            this.pnlWyboru.Controls.Add(frmProdukty_op);
            frmProdukty_op.Show();
            //222; 140; 135 - jasny róż
            //209; 133; 119 - ciemny róż
            //BurlyWood - jasny żółty
            //209; 166; 119 - ciemny żółty
        }

        private void btnKategoriaZwierzeta_Click(object sender, EventArgs e)
        {
            //zmiana pokazywanej kategorii na frmZwierzeta
            btnKategoriaZwierzeta.BackColor = Color.FromArgb(222,140,135);
            btnKategoriaProdukty.BackColor = Color.FromArgb(209,133,119);
            this.pnlWyboru.Controls.Clear();
            frmZwierzeta frmZwierzeta_op = new frmZwierzeta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmZwierzeta_op.FormBorderStyle = FormBorderStyle.None;
            this.pnlWyboru.Controls.Add(frmZwierzeta_op);
            frmZwierzeta_op.Show();
        }

        private void btnKategoriaProdukty_Click(object sender, EventArgs e)
        {
            //zmiana pokazywanej kategorii na frmProdukty
            btnKategoriaZwierzeta.BackColor = Color.FromArgb(209,166,119);
            btnKategoriaProdukty.BackColor = Color.FromKnownColor(KnownColor.BurlyWood);
            this.pnlWyboru.Controls.Clear();
            frmProdukty frmProdukty_op = new frmProdukty() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProdukty_op.FormBorderStyle = FormBorderStyle.None;
            this.pnlWyboru.Controls.Add(frmProdukty_op);
            frmProdukty_op.Show();
        }
    }
}
