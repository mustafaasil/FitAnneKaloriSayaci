namespace FitAnneKaloriSayaci.UI
{
    partial class KategoriDuzenlemeEkraniAdmin
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
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.grpKategoriIslemleri = new System.Windows.Forms.GroupBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.grpKategoriIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(427, 24);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(192, 36);
            this.btnKategoriEkle.TabIndex = 15;
            this.btnKategoriEkle.Text = "KATEGORİ EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(427, 80);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(192, 36);
            this.btnKategoriGuncelle.TabIndex = 14;
            this.btnKategoriGuncelle.Text = "KATEGORİ GÜNCELLE";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(427, 140);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(192, 36);
            this.btnKategoriSil.TabIndex = 13;
            this.btnKategoriSil.Text = "KATEGORİ SİL";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategoriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(20, 200);
            this.dgvKategoriler.MultiSelect = false;
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.ReadOnly = true;
            this.dgvKategoriler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvKategoriler.RowTemplate.Height = 25;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(599, 223);
            this.dgvKategoriler.TabIndex = 12;
            this.dgvKategoriler.DoubleClick += new System.EventHandler(this.dgvKategoriler_DoubleClick);
            // 
            // grpKategoriIslemleri
            // 
            this.grpKategoriIslemleri.Controls.Add(this.txtKategori);
            this.grpKategoriIslemleri.Controls.Add(this.label1);
            this.grpKategoriIslemleri.Location = new System.Drawing.Point(20, 24);
            this.grpKategoriIslemleri.Name = "grpKategoriIslemleri";
            this.grpKategoriIslemleri.Size = new System.Drawing.Size(366, 152);
            this.grpKategoriIslemleri.TabIndex = 11;
            this.grpKategoriIslemleri.TabStop = false;
            this.grpKategoriIslemleri.Text = "Kategori İşlemleri";
            // 
            // txtKategori
            // 
            this.txtKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKategori.Location = new System.Drawing.Point(144, 61);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(160, 29);
            this.txtKategori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // KategoriDuzenlemeEkraniAdmin
            // 
            this.AcceptButton = this.btnKategoriEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(638, 447);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.dgvKategoriler);
            this.Controls.Add(this.grpKategoriIslemleri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(654, 486);
            this.MinimumSize = new System.Drawing.Size(654, 486);
            this.Name = "KategoriDuzenlemeEkraniAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı-Kategori Düzenleme Ekranı Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KategoriDuzenlemeEkrani_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.grpKategoriIslemleri.ResumeLayout(false);
            this.grpKategoriIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnKategoriEkle;
        private Button btnKategoriGuncelle;
        private Button btnKategoriSil;
        private DataGridView dgvKategoriler;
        private GroupBox grpKategoriIslemleri;
        private TextBox txtKategori;
        private Label label1;
    }
}