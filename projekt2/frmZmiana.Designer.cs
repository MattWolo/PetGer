namespace projekt2
{
    partial class frmZmiana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZmiana));
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnZmien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewHaslo2nd = new System.Windows.Forms.TextBox();
            this.txtNewHaslo = new System.Windows.Forms.TextBox();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOldHaslo = new System.Windows.Forms.TextBox();
            this.txtOldLogin = new System.Windows.Forms.TextBox();
            this.lblProdukty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(369, 171);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij.TabIndex = 7;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnZmien
            // 
            this.btnZmien.Location = new System.Drawing.Point(288, 171);
            this.btnZmien.Name = "btnZmien";
            this.btnZmien.Size = new System.Drawing.Size(75, 23);
            this.btnZmien.TabIndex = 6;
            this.btnZmien.Text = "Zmień";
            this.btnZmien.UseVisualStyleBackColor = true;
            this.btnZmien.Click += new System.EventHandler(this.btnZmien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.txtNewHaslo2nd);
            this.panel1.Controls.Add(this.txtNewHaslo);
            this.panel1.Controls.Add(this.txtNewLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(234, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 157);
            this.panel1.TabIndex = 10;
            // 
            // txtNewHaslo2nd
            // 
            this.txtNewHaslo2nd.Location = new System.Drawing.Point(27, 124);
            this.txtNewHaslo2nd.Name = "txtNewHaslo2nd";
            this.txtNewHaslo2nd.PlaceholderText = "Powtórz hasło...";
            this.txtNewHaslo2nd.Size = new System.Drawing.Size(159, 23);
            this.txtNewHaslo2nd.TabIndex = 5;
            this.txtNewHaslo2nd.UseSystemPasswordChar = true;
            // 
            // txtNewHaslo
            // 
            this.txtNewHaslo.Location = new System.Drawing.Point(27, 95);
            this.txtNewHaslo.Name = "txtNewHaslo";
            this.txtNewHaslo.PlaceholderText = "Nowe hasło...";
            this.txtNewHaslo.Size = new System.Drawing.Size(159, 23);
            this.txtNewHaslo.TabIndex = 4;
            this.txtNewHaslo.UseSystemPasswordChar = true;
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Location = new System.Drawing.Point(27, 66);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.PlaceholderText = "Nowy login...";
            this.txtNewLogin.Size = new System.Drawing.Size(159, 23);
            this.txtNewLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Wprowadź\rnowe dane";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.txtOldHaslo);
            this.panel2.Controls.Add(this.txtOldLogin);
            this.panel2.Controls.Add(this.lblProdukty);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 157);
            this.panel2.TabIndex = 11;
            // 
            // txtOldHaslo
            // 
            this.txtOldHaslo.Location = new System.Drawing.Point(26, 95);
            this.txtOldHaslo.Name = "txtOldHaslo";
            this.txtOldHaslo.PlaceholderText = "Stare hasło...";
            this.txtOldHaslo.Size = new System.Drawing.Size(159, 23);
            this.txtOldHaslo.TabIndex = 2;
            this.txtOldHaslo.UseSystemPasswordChar = true;
            // 
            // txtOldLogin
            // 
            this.txtOldLogin.Location = new System.Drawing.Point(26, 66);
            this.txtOldLogin.Name = "txtOldLogin";
            this.txtOldLogin.PlaceholderText = "Stary login...";
            this.txtOldLogin.Size = new System.Drawing.Size(159, 23);
            this.txtOldLogin.TabIndex = 1;
            // 
            // lblProdukty
            // 
            this.lblProdukty.AutoSize = true;
            this.lblProdukty.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProdukty.Location = new System.Drawing.Point(38, 11);
            this.lblProdukty.Name = "lblProdukty";
            this.lblProdukty.Size = new System.Drawing.Size(125, 46);
            this.lblProdukty.TabIndex = 33;
            this.lblProdukty.Text = "Wprowadź\r\nstare dane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "*nowe dane muszą zawierać conajmniej 8 znaków";
            // 
            // frmZmiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZmien);
            this.Controls.Add(this.btnZamknij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(472, 241);
            this.MinimumSize = new System.Drawing.Size(472, 241);
            this.Name = "frmZmiana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnZamknij;
        private Button btnZmien;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label lblProdukty;
        private TextBox txtNewHaslo;
        private TextBox txtNewLogin;
        private TextBox txtOldHaslo;
        private TextBox txtOldLogin;
        private TextBox txtNewHaslo2nd;
    }
}