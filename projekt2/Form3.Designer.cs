namespace projekt2
{
    partial class frmBaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaza));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.mtxtIlosc = new System.Windows.Forms.MaskedTextBox();
            this.cboxProdukt = new System.Windows.Forms.ComboBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.cboxSzukaj = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Produktów w Magazynie";
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AllowUserToAddRows = false;
            this.dgvProdukty.AllowUserToOrderColumns = true;
            this.dgvProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdukty.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvProdukty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdukty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dgvProdukty.EnableHeadersVisualStyles = false;
            this.dgvProdukty.Location = new System.Drawing.Point(50, 110);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.RowHeadersVisible = false;
            this.dgvProdukty.RowTemplate.Height = 25;
            this.dgvProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdukty.Size = new System.Drawing.Size(750, 400);
            this.dgvProdukty.TabIndex = 2;
            this.dgvProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProdukty_CellClick);
            this.dgvProdukty.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtvProdukty_RowPostPaint);
            // 
            // id
            // 
            this.id.FillWeight = 20F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(400, 82);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.PlaceholderText = "Nazwa produktu";
            this.txtNazwa.Size = new System.Drawing.Size(96, 23);
            this.txtNazwa.TabIndex = 3;
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
            // mtxtIlosc
            // 
            this.mtxtIlosc.Location = new System.Drawing.Point(579, 82);
            this.mtxtIlosc.Mask = "00000";
            this.mtxtIlosc.Name = "mtxtIlosc";
            this.mtxtIlosc.Size = new System.Drawing.Size(40, 23);
            this.mtxtIlosc.TabIndex = 5;
            this.mtxtIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtIlosc.ValidatingType = typeof(int);
            // 
            // cboxProdukt
            // 
            this.cboxProdukt.FormattingEnabled = true;
            this.cboxProdukt.Items.AddRange(new object[] {
            "Karmy",
            "Smycze",
            "Zabawki",
            "Kuwety",
            "Żwirki",
            "Przysmaki",
            "Obroże",
            "Drapaki",
            "Klatki",
            "Granulaty i ściółki",
            "Miski",
            "Ubranka",
            "Koce i legowiska",
            "Akwaria",
            "Dodatki do akwariów"});
            this.cboxProdukt.Location = new System.Drawing.Point(625, 81);
            this.cboxProdukt.Name = "cboxProdukt";
            this.cboxProdukt.Size = new System.Drawing.Size(94, 23);
            this.cboxProdukt.TabIndex = 6;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(502, 82);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(71, 23);
            this.mtxtData.TabIndex = 4;
            this.mtxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtData_TypeValidationCompleted);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(50, 81);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.PlaceholderText = "Nazwa Produktu";
            this.txtSzukaj.Size = new System.Drawing.Size(180, 23);
            this.txtSzukaj.TabIndex = 1;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // cboxSzukaj
            // 
            this.cboxSzukaj.FormattingEnabled = true;
            this.cboxSzukaj.Items.AddRange(new object[] {
            "Wszystko",
            "Karmy",
            "Smycze",
            "Zabawki",
            "Kuwety",
            "Żwirki",
            "Przysmaki",
            "Obroże",
            "Drapaki",
            "Klatki",
            "Granulaty i ściółki",
            "Miski",
            "Ubranka",
            "Koce i legowiska",
            "Akwaria",
            "Dodatki do akwariów"});
            this.cboxSzukaj.Location = new System.Drawing.Point(236, 81);
            this.cboxSzukaj.Name = "cboxSzukaj";
            this.cboxSzukaj.Size = new System.Drawing.Size(76, 23);
            this.cboxSzukaj.TabIndex = 2;
            this.cboxSzukaj.SelectedIndexChanged += new System.EventHandler(this.cboxSzukaj_SelectedIndexChanged);
            // 
            // frmBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 555);
            this.Controls.Add(this.cboxSzukaj);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.cboxProdukt);
            this.Controls.Add(this.mtxtIlosc);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.dgvProdukty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(864, 594);
            this.MinimumSize = new System.Drawing.Size(864, 594);
            this.Name = "frmBaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGer";
            this.Load += new System.EventHandler(this.frmBaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvProdukty;
        private TextBox txtNazwa;
        private Button btnDodaj;
        private Button btnZapisz;
        private Button btnZamknij;
        private MaskedTextBox mtxtIlosc;
        private ComboBox cboxProdukt;
        private Button btnWczytaj;
        private MaskedTextBox mtxtData;
        private TextBox txtSzukaj;
        private ComboBox cboxSzukaj;
        private DataGridViewTextBoxColumn id;
    }
}