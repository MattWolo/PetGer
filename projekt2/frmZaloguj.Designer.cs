namespace projekt2
{
    partial class frmZaloguj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaloguj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZmien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnZmien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.btnZaloguj);
            this.panel1.Controls.Add(this.txtHaslo);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 555);
            this.panel1.TabIndex = 0;
            // 
            // btnZmien
            // 
            this.btnZmien.Location = new System.Drawing.Point(106, 292);
            this.btnZmien.Name = "btnZmien";
            this.btnZmien.Size = new System.Drawing.Size(89, 23);
            this.btnZmien.TabIndex = 11;
            this.btnZmien.Text = "Zmień dane";
            this.btnZmien.UseVisualStyleBackColor = true;
            this.btnZmien.Click += new System.EventHandler(this.btnZmien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 96);
            this.label1.TabIndex = 10;
            this.label1.Text = "    Witaj\r\nZaloguj się\r\n";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(310, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(556, 537);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(113, 263);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(75, 23);
            this.btnZaloguj.TabIndex = 7;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(74, 234);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PlaceholderText = "Hasło...";
            this.txtHaslo.Size = new System.Drawing.Size(159, 23);
            this.txtHaslo.TabIndex = 6;
            this.txtHaslo.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(74, 205);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PlaceholderText = "Login...";
            this.txtLogin.Size = new System.Drawing.Size(159, 23);
            this.txtLogin.TabIndex = 5;
            // 
            // frmZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmZaloguj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private Button btnZaloguj;
        private TextBox txtHaslo;
        private TextBox txtLogin;
        private Label label1;
        private Button btnZmien;
    }
}