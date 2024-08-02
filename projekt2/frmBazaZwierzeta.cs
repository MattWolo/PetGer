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
    public partial class frmBazaZwierzeta : Form
    {
        DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
        public frmBazaZwierzeta()
        {
            InitializeComponent();
        }

        DataTable table2 = new DataTable();

        private void frmBazaZwierzeta_Load(object sender, EventArgs e)
        {
            table2.Columns.Add("Wabi", typeof(string));
            table2.Columns.Add("Data przybycia", typeof(DateTime));
            table2.Columns.Add("Płeć", typeof(string));
            table2.Columns.Add("Rasa", typeof(string));
            dgvZwierzeta.DataSource = table2;

            btnRemove.HeaderText = "Usuń";
            btnRemove.Text = "delete";
            btnRemove.Name = "btn";
            btnRemove.FillWeight = 50;
            btnRemove.UseColumnTextForButtonValue = true;
            dgvZwierzeta.Columns.Add(btnRemove);

            cboxSzukaj2.Text = frmZwierzeta.FilterZwierzeta;

            string[] lines = File.ReadAllLines("BazaZwierzat.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table2.Rows.Add(row);
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            cboxSzukaj2.Text = "Wszystko";
            using (TextWriter tw = new StreamWriter("BazaZwierzat.txt"))
            {
                for (int i = 0; i < dgvZwierzeta.Rows.Count; i++)
                {
                    for (int j = 2; j < dgvZwierzeta.Columns.Count; j++)
                    {
                        tw.Write($"{dgvZwierzeta.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dgvZwierzeta.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
            MessageBox.Show("Zapisano", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvZwierzęta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvZwierzeta.Columns["btn"].Index && e.RowIndex >= 0)
            {
                int index = Convert.ToInt32(e.RowIndex);
                table2.Rows[index].Delete();
                dgvZwierzeta.DataSource = table2;             //usuwa row na przycisk
            }
        }

        private void dgvZwierzęta_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvZwierzeta.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNazwa2.Text == "" || mtxtData2.Text == "" || cboxSex.Text == "" || cboxZwierze.Text=="")            //checks if empty
            {
                MessageBox.Show("Jedno z pól jest pustych, lub nieprawidłowych. Uzupełnij je!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                table2.Rows.Add(txtNazwa2.Text, mtxtData2.Text, cboxSex.Text, cboxZwierze.Text); //ustawia dane w nowym row
            }
        }

        private void mtxtData2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Błędna Data";
                toolTip1.Show("Data musi być w formacie DD/MM/RRRR.", mtxtData2, 0, -60, 2000);
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now)
                {
                    toolTip1.ToolTipTitle = "Błędna Data";
                    toolTip1.Show("Data nie może być przeszłości", mtxtData2, 0, -60, 2000);
                    e.Cancel = true;
                }
            }
        }

        private void txtSzukaj2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table2.DefaultView;
            dv.RowFilter = "Wabi LIKE '" + txtSzukaj2.Text + "%'";
            dgvZwierzeta.DataSource = dv;
        }

        private void cboxSzukaj2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = table2.DefaultView;
            if (cboxSzukaj2.Text == "Wszystko")
            {
                dv.RowFilter = String.Empty;
            }
            else
            {
                dv.RowFilter = "Rasa LIKE '" + cboxSzukaj2.Text + "%'";
                dgvZwierzeta.DataSource = dv;
            }
        }
    }
}
