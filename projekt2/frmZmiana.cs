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
    public partial class frmZmiana : Form
    {
        public frmZmiana()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            string FilePath = "dane.txt";
            string[] dane = File.ReadAllLines(FilePath);
            if (txtOldLogin.Text == dane[0] && txtOldHaslo.Text == dane[1] && txtNewHaslo.TextLength >= 8 && txtNewHaslo.Text == txtNewHaslo2nd.Text)
            {
                List<string> wiersze = new List<string>();
                wiersze.Add(
                    txtNewLogin.Text + "\n" +
                    txtNewHaslo.Text

                    );
                File.WriteAllLines(FilePath, wiersze);
                MessageBox.Show("Dane zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewHaslo.Text = "";
                txtNewLogin.Text = "";
                txtOldHaslo.Text = "";
                txtOldLogin.Text = "";
                txtNewHaslo2nd.Text = "";

            }
            else if(txtOldLogin.Text != dane[0] && txtOldHaslo.Text != dane[1] )
            {
                MessageBox.Show("Podano błędne stare hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNewHaslo.TextLength < 8)
            {
                MessageBox.Show("Nowe hasło jest za krótkie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNewHaslo.Text != txtNewHaslo2nd.Text)
            {
                MessageBox.Show("Nowe hasło zostało powtórzone błędnie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
