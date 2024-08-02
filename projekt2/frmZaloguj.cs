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
    public partial class frmZaloguj : Form
    {
        public frmZaloguj()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string FilePath = "dane.txt";
            string[] dane = File.ReadAllLines(FilePath);          //Wczytuje do tabeli dane z pliku tekstowego
            if (txtLogin.Text == dane[0] && txtHaslo.Text == dane[1])   //Sprawdza czy podany login i hasło się zgadza
            {
                frmWybor frmWybor_op = new frmWybor();
                frmWybor_op.Show();
                this.Hide();
            }
            else if (txtHaslo.Text != dane[1] && txtLogin.Text != dane[0])
            {
                MessageBox.Show("Błędne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtHaslo.Text != dane[1])
            {
                MessageBox.Show("Błędne hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Błędny login!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            frmZmiana frmZmiana_op = new frmZmiana();
            frmZmiana_op.Show();
        }
    }
}
