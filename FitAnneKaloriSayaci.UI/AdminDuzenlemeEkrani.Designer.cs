namespace FitAnneKaloriSayaci.UI
{
    partial class AdminDuzenlemeEkrani
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
            this.grpAdminIslemleri = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdminGuncelle = new System.Windows.Forms.Button();
            this.dgvAdminler = new System.Windows.Forms.DataGridView();
            this.btnAdminSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAdminSifreTekrari = new System.Windows.Forms.TextBox();
            this.grpAdminIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdminIslemleri
            // 
            this.grpAdminIslemleri.Controls.Add(this.label11);
            this.grpAdminIslemleri.Controls.Add(this.btnAdminGuncelle);
            this.grpAdminIslemleri.Controls.Add(this.dgvAdminler);
            this.grpAdminIslemleri.Controls.Add(this.btnAdminSil);
            this.grpAdminIslemleri.Controls.Add(this.label6);
            this.grpAdminIslemleri.Controls.Add(this.btnAdminEkle);
            this.grpAdminIslemleri.Controls.Add(this.label4);
            this.grpAdminIslemleri.Controls.Add(this.txtAdminEmail);
            this.grpAdminIslemleri.Controls.Add(this.txtAdminSifre);
            this.grpAdminIslemleri.Controls.Add(this.label20);
            this.grpAdminIslemleri.Controls.Add(this.txtAdminSifreTekrari);
            this.grpAdminIslemleri.Location = new System.Drawing.Point(14, 18);
            this.grpAdminIslemleri.Name = "grpAdminIslemleri";
            this.grpAdminIslemleri.Size = new System.Drawing.Size(918, 292);
            this.grpAdminIslemleri.TabIndex = 36;
            this.grpAdminIslemleri.TabStop = false;
            this.grpAdminIslemleri.Text = "Admin İşlemleri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Adminler Listesi";
            // 
            // btnAdminGuncelle
            // 
            this.btnAdminGuncelle.Location = new System.Drawing.Point(32, 226);
            this.btnAdminGuncelle.Name = "btnAdminGuncelle";
            this.btnAdminGuncelle.Size = new System.Drawing.Size(420, 35);
            this.btnAdminGuncelle.TabIndex = 33;
            this.btnAdminGuncelle.Text = "ADMİN GÜNCELLE";
            this.btnAdminGuncelle.UseVisualStyleBackColor = true;
            this.btnAdminGuncelle.Click += new System.EventHandler(this.btnAdminGuncelle_Click);
            // 
            // dgvAdminler
            // 
            this.dgvAdminler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdminler.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminler.Location = new System.Drawing.Point(482, 48);
            this.dgvAdminler.MultiSelect = false;
            this.dgvAdminler.Name = "dgvAdminler";
            this.dgvAdminler.ReadOnly = true;
            this.dgvAdminler.RowHeadersWidth = 51;
            this.dgvAdminler.RowTemplate.Height = 29;
            this.dgvAdminler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminler.Size = new System.Drawing.Size(410, 213);
            this.dgvAdminler.TabIndex = 0;
            this.dgvAdminler.DoubleClick += new System.EventHandler(this.dgvAdminler_DoubleClick);
            // 
            // btnAdminSil
            // 
            this.btnAdminSil.Location = new System.Drawing.Point(259, 173);
            this.btnAdminSil.Name = "btnAdminSil";
            this.btnAdminSil.Size = new System.Drawing.Size(193, 38);
            this.btnAdminSil.TabIndex = 32;
            this.btnAdminSil.Text = "ADMİN SİL";
            this.btnAdminSil.UseVisualStyleBackColor = true;
            this.btnAdminSil.Click += new System.EventHandler(this.btnAdminSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.Location = new System.Drawing.Point(31, 173);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(195, 38);
            this.btnAdminEkle.TabIndex = 4;
            this.btnAdminEkle.Text = "ADMİN EKLE";
            this.btnAdminEkle.UseVisualStyleBackColor = true;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminEmail.Location = new System.Drawing.Point(175, 32);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(277, 29);
            this.txtAdminEmail.TabIndex = 1;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminSifre.Location = new System.Drawing.Point(175, 78);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(277, 29);
            this.txtAdminSifre.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 21);
            this.label20.TabIndex = 21;
            this.label20.Text = "Şifre Tekrari:";
            // 
            // txtAdminSifreTekrari
            // 
            this.txtAdminSifreTekrari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminSifreTekrari.Location = new System.Drawing.Point(175, 124);
            this.txtAdminSifreTekrari.Name = "txtAdminSifreTekrari";
            this.txtAdminSifreTekrari.Size = new System.Drawing.Size(277, 29);
            this.txtAdminSifreTekrari.TabIndex = 3;
            // 
            // AdminDuzenlemeEkrani
            // 
            this.AcceptButton = this.btnAdminEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(947, 328);
            this.Controls.Add(this.grpAdminIslemleri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(963, 367);
            this.MinimumSize = new System.Drawing.Size(963, 367);
            this.Name = "AdminDuzenlemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı-Admin Düzenleme Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDuzenlemeEkrani_FormClosed);
            this.grpAdminIslemleri.ResumeLayout(false);
            this.grpAdminIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpAdminIslemleri;
        private Label label11;
        private Button btnAdminGuncelle;
        private DataGridView dgvAdminler;
        private Button btnAdminSil;
        private Label label6;
        private Button btnAdminEkle;
        private Label label4;
        private TextBox txtAdminAdı;
        private TextBox txtAdminSifre;
        private Label label20;
        private TextBox txtAdminSifreTekrari;
        private TextBox txtAdminEmail;
    }
}