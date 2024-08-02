using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace projekt2
{
    public partial class frmBaza : Form
    {
        DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();


        public frmBaza()
        {
            InitializeComponent();
        }

        DataTable table1 = new DataTable();
        

        private void frmBaza_Load(object sender, EventArgs e)
        {
            table1.Columns.Add("Produkt", typeof(string));
            table1.Columns.Add("data dostawy", typeof(DateTime));
            table1.Columns.Add("ilość", typeof(int));
            table1.Columns.Add("Typ", typeof(string));
            dgvProdukty.DataSource = table1;

            btnRemove.HeaderText = "Usuń";
            btnRemove.Text = "delete";
            btnRemove.Name = "btn";
            btnRemove.FillWeight = 50;
            btnRemove.UseColumnTextForButtonValue = true;
            dgvProdukty.Columns.Add(btnRemove);

            cboxSzukaj.Text = frmProdukty.FilterValue;

            string[] lines = File.ReadAllLines("BazaSklepu.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table1.Rows.Add(row);
            }
        }

        private void dtvProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProdukty.Columns["btn"].Index && e.RowIndex >= 0)
            {
                int index = Convert.ToInt32(e.RowIndex);
                table1.Rows[index].Delete();
                dgvProdukty.DataSource = table1;             //usuwa row na przycisk
            }
        }
        
        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtxtData_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Błędna Data";
                toolTip1.Show("Data musi być w formacie DD/MM/RRRR.", mtxtData, 0, -60, 2000);
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now)
                {
                    toolTip1.ToolTipTitle = "Błędna Data";
                    toolTip1.Show("Data nie może być przeszłości", mtxtData, 0, -60, 2000);
                    e.Cancel = true;
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {        
            
            if (txtNazwa.Text == "" || mtxtData.Text == "" || mtxtIlosc.Text == "")          //checks if empty
            {
                MessageBox.Show("Jedno z pól jest pustych, lub nieprawidłowych. Uzupełnij je!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                table1.Rows.Add(txtNazwa.Text, mtxtData.Text,mtxtIlosc.Text.Trim(),cboxProdukt.Text.Trim()); //ustawia dane w nowym row
            }
        }

        private void dtvProdukty_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvProdukty.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            cboxSzukaj.Text = "Wszystko";
            using (TextWriter tw = new StreamWriter("BazaSklepu.txt"))
            {
                for (int i = 0; i < dgvProdukty.Rows.Count; i++)
                {
                    for (int j = 2; j < dgvProdukty.Columns.Count; j++)
                    {
                        tw.Write($"{dgvProdukty.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dgvProdukty.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine(); 
                }
            }
            MessageBox.Show("Zapisano", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table1.DefaultView;
            dv.RowFilter = "Produkt LIKE '" + txtSzukaj.Text + "%'";
            dgvProdukty.DataSource = dv;
        }

        private void cboxSzukaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = table1.DefaultView;
            if (cboxSzukaj.Text == "Wszystko")
            {
                dv.RowFilter = String.Empty;
            }
            else
            {
                dv.RowFilter = "Typ LIKE '" + cboxSzukaj.Text + "%'";
                dgvProdukty.DataSource = dv;
            }   
        }
    }
}

