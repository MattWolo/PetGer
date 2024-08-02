namespace projekt2
{
    partial class frmBazaZwierzeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBazaZwierzeta));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZwierzeta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.txtNazwa2 = new System.Windows.Forms.TextBox();
            this.mtxtData2 = new System.Windows.Forms.MaskedTextBox();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.cboxZwierze = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSzukaj2 = new System.Windows.Forms.TextBox();
            this.cboxSzukaj2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwierzeta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Zwierząt w Magazynie";
            // 
            // dgvZwierzeta
            // 
            this.dgvZwierzeta.AllowUserToAddRows = false;
            this.dgvZwierzeta.AllowUserToOrderColumns = true;
            this.dgvZwierzeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZwierzeta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.dgvZwierzeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZwierzeta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZwierzeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZwierzeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dgvZwierzeta.EnableHeadersVisualStyles = false;
            this.dgvZwierzeta.Location = new System.Drawing.Point(50, 110);
            this.dgvZwierzeta.Name = "dgvZwierzeta";
            this.dgvZwierzeta.RowHeadersVisible = false;
            this.dgvZwierzeta.RowTemplate.Height = 25;
            this.dgvZwierzeta.Size = new System.Drawing.Size(750, 400);
            this.dgvZwierzeta.TabIndex = 3;
            this.dgvZwierzeta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZwierzęta_CellClick);
            this.dgvZwierzeta.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvZwierzęta_RowPostPaint);
            // 
            // id
            // 
            this.id.FillWeight = 10F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(768, 520);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij.TabIndex = 9;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(687, 520);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // txtNazwa2
            // 
            this.txtNazwa2.Location = new System.Drawing.Point(375, 82);
            this.txtNazwa2.Name = "txtNazwa2";
            this.txtNazwa2.PlaceholderText = "Nazwa";
            this.txtNazwa2.Size = new System.Drawing.Size(94, 23);
            this.txtNazwa2.TabIndex = 3;
            // 
            // mtxtData2
            // 
            this.mtxtData2.Location = new System.Drawing.Point(554, 81);
            this.mtxtData2.Mask = "00/00/0000";
            this.mtxtData2.Name = "mtxtData2";
            this.mtxtData2.Size = new System.Drawing.Size(62, 23);
            this.mtxtData2.TabIndex = 5;
            this.mtxtData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtData2.ValidatingType = typeof(System.DateTime);
            this.mtxtData2.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtData2_TypeValidationCompleted);
            // 
            // cboxSex
            // 
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Items.AddRange(new object[] {
            "Samiec",
            "Samica"});
            this.cboxSex.Location = new System.Drawing.Point(475, 81);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(73, 23);
            this.cboxSex.TabIndex = 4;
            // 
            // cboxZwierze
            // 
            this.cboxZwierze.FormattingEnabled = true;
            this.cboxZwierze.Items.AddRange(new object[] {
            "Koszatniczki",
            "Szynszyle",
            "Pająki",
            "Szczury",
            "Kawie domowe",
            "Węże",
            "Myszy",
            "Króliki",
            "Jaszczurki",
            "Myszoskoczki",
            "Jeże",
            "Żółwie",
            "Chomiki",
            "Papużki",
            "Rybki"});
            this.cboxZwierze.Location = new System.Drawing.Point(622, 81);
            this.cboxZwierze.Name = "cboxZwierze";
            this.cboxZwierze.Size = new System.Drawing.Size(97, 23);
            this.cboxZwierze.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(725, 81);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSzukaj2
            // 
            this.txtSzukaj2.Location = new System.Drawing.Point(50, 81);
            this.txtSzukaj2.Name = "txtSzukaj2";
            this.txtSzukaj2.PlaceholderText = "Jak się wabi";
            this.txtSzukaj2.Size = new System.Drawing.Size(137, 23);
            this.txtSzukaj2.TabIndex = 1;
            this.txtSzukaj2.TextChanged += new System.EventHandler(this.txtSzukaj2_TextChanged);
            // 
            // cboxSzukaj2
            // 
            this.cboxSzukaj2.FormattingEnabled = true;
            this.cboxSzukaj2.Items.AddRange(new object[] {
            "Wszystko",
            "Koszatniczki",
            "Szynszyle",
            "Pająki",
            "Szczury",
            "Kawie domowe",
            "Węże",
            "Myszy",
            "Króliki",
            "Jaszczurki",
            "Myszoskoczki",
            "Jeże",
            "Żółwie",
            "Chomiki",
            "Papużki",
            "Rybki"});
            this.cboxSzukaj2.Location = new System.Drawing.Point(193, 82);
            this.cboxSzukaj2.Name = "cboxSzukaj2";
            this.cboxSzukaj2.Size = new System.Drawing.Size(86, 23);
            this.cboxSzukaj2.TabIndex = 2;
            this.cboxSzukaj2.SelectedIndexChanged += new System.EventHandler(this.cboxSzukaj2_SelectedIndexChanged);
            // 
            // frmBazaZwierzeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 555);
            this.Controls.Add(this.cboxSzukaj2);
            this.Controls.Add(this.txtSzukaj2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cboxZwierze);
            this.Controls.Add(this.cboxSex);
            this.Controls.Add(this.mtxtData2);
            this.Controls.Add(this.txtNazwa2);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dgvZwierzeta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(864, 594);
            this.MinimumSize = new System.Drawing.Size(864, 594);
            this.Name = "frmBazaZwierzeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGer";
            this.Load += new System.EventHandler(this.frmBazaZwierzeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwierzeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvZwierzeta;
        private Button btnZamknij;
        private Button btnZapisz;
        private TextBox txtNazwa2;
        private MaskedTextBox mtxtData2;
        private ComboBox cboxSex;
        private ComboBox cboxZwierze;
        private Button btnDodaj;
        private TextBox txtSzukaj2;
        private ComboBox cboxSzukaj2;
        private DataGridViewTextBoxColumn id;
    }
}