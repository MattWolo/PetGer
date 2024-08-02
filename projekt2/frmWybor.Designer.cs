namespace projekt2
{
    partial class frmWybor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWybor));
            this.pnlWyboru = new System.Windows.Forms.Panel();
            this.btnKategoriaZwierzeta = new System.Windows.Forms.Button();
            this.btnKategoriaProdukty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlWyboru
            // 
            this.pnlWyboru.Location = new System.Drawing.Point(0, 0);
            this.pnlWyboru.Name = "pnlWyboru";
            this.pnlWyboru.Size = new System.Drawing.Size(884, 516);
            this.pnlWyboru.TabIndex = 0;
            // 
            // btnKategoriaZwierzeta
            // 
            this.btnKategoriaZwierzeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(166)))), ((int)(((byte)(119)))));
            this.btnKategoriaZwierzeta.FlatAppearance.BorderSize = 0;
            this.btnKategoriaZwierzeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriaZwierzeta.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriaZwierzeta.ForeColor = System.Drawing.Color.Black;
            this.btnKategoriaZwierzeta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKategoriaZwierzeta.Location = new System.Drawing.Point(445, 513);
            this.btnKategoriaZwierzeta.Name = "btnKategoriaZwierzeta";
            this.btnKategoriaZwierzeta.Size = new System.Drawing.Size(445, 50);
            this.btnKategoriaZwierzeta.TabIndex = 20;
            this.btnKategoriaZwierzeta.Text = "Zwierzęta";
            this.btnKategoriaZwierzeta.UseVisualStyleBackColor = false;
            this.btnKategoriaZwierzeta.Click += new System.EventHandler(this.btnKategoriaZwierzeta_Click);
            // 
            // btnKategoriaProdukty
            // 
            this.btnKategoriaProdukty.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKategoriaProdukty.FlatAppearance.BorderSize = 0;
            this.btnKategoriaProdukty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriaProdukty.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriaProdukty.ForeColor = System.Drawing.Color.Black;
            this.btnKategoriaProdukty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriaProdukty.Location = new System.Drawing.Point(0, 513);
            this.btnKategoriaProdukty.Name = "btnKategoriaProdukty";
            this.btnKategoriaProdukty.Size = new System.Drawing.Size(448, 50);
            this.btnKategoriaProdukty.TabIndex = 19;
            this.btnKategoriaProdukty.Text = "Produkty";
            this.btnKategoriaProdukty.UseVisualStyleBackColor = false;
            this.btnKategoriaProdukty.Click += new System.EventHandler(this.btnKategoriaProdukty_Click);
            // 
            // frmWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnKategoriaZwierzeta);
            this.Controls.Add(this.btnKategoriaProdukty);
            this.Controls.Add(this.pnlWyboru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmWybor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGer";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlWyboru;
        private Button btnKategoriaZwierzeta;
        private Button btnKategoriaProdukty;
    }
}