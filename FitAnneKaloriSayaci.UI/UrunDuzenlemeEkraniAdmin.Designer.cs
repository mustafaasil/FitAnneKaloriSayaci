namespace FitAnneKaloriSayaci.UI
{
    partial class UrunDuzenlemeEkraniAdmin
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.grpUrunIslemleri = new System.Windows.Forms.GroupBox();
            this.pbUrunResmi = new System.Windows.Forms.PictureBox();
            this.nudKalori = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.grpUrunIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(586, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(159, 36);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "ÜRÜN EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(586, 106);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(159, 36);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "ÜRÜN GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(586, 172);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(159, 36);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "ÜRÜN SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(18, 280);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowTemplate.Height = 75;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(757, 193);
            this.dgvUrunler.TabIndex = 7;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // grpUrunIslemleri
            // 
            this.grpUrunIslemleri.Controls.Add(this.pbUrunResmi);
            this.grpUrunIslemleri.Controls.Add(this.nudKalori);
            this.grpUrunIslemleri.Controls.Add(this.label3);
            this.grpUrunIslemleri.Controls.Add(this.btnResimEkle);
            this.grpUrunIslemleri.Controls.Add(this.cmbKategori);
            this.grpUrunIslemleri.Controls.Add(this.label2);
            this.grpUrunIslemleri.Controls.Add(this.txtAd);
            this.grpUrunIslemleri.Controls.Add(this.label1);
            this.grpUrunIslemleri.Location = new System.Drawing.Point(12, 12);
            this.grpUrunIslemleri.Name = "grpUrunIslemleri";
            this.grpUrunIslemleri.Size = new System.Drawing.Size(555, 253);
            this.grpUrunIslemleri.TabIndex = 6;
            this.grpUrunIslemleri.TabStop = false;
            this.grpUrunIslemleri.Text = "Ürün İşlemleri";
            // 
            // pbUrunResmi
            // 
            this.pbUrunResmi.BackColor = System.Drawing.Color.White;
            this.pbUrunResmi.Location = new System.Drawing.Point(379, 39);
            this.pbUrunResmi.Name = "pbUrunResmi";
            this.pbUrunResmi.Size = new System.Drawing.Size(147, 122);
            this.pbUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrunResmi.TabIndex = 6;
            this.pbUrunResmi.TabStop = false;
            // 
            // nudKalori
            // 
            this.nudKalori.Location = new System.Drawing.Point(144, 132);
            this.nudKalori.Margin = new System.Windows.Forms.Padding(4);
            this.nudKalori.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKalori.Name = "nudKalori";
            this.nudKalori.Size = new System.Drawing.Size(120, 29);
            this.nudKalori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Kalorisi :";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(379, 183);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(147, 36);
            this.btnResimEkle.TabIndex = 4;
            this.btnResimEkle.Text = "RESİM EKLE";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(144, 39);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(160, 29);
            this.cmbKategori.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(144, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(160, 29);
            this.txtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // UrunDuzenlemeEkraniAdmin
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(788, 489);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.grpUrunIslemleri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(804, 528);
            this.MinimumSize = new System.Drawing.Size(804, 528);
            this.Name = "UrunDuzenlemeEkraniAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı- Admin Ürün Düzenleme Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunDuzenlemeEkrani_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.grpUrunIslemleri.ResumeLayout(false);
            this.grpUrunIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvUrunler;
        private GroupBox grpUrunIslemleri;
        private PictureBox pbUrunResmi;
        private NumericUpDown nudKalori;
        private Label label3;
        private Button btnResimEkle;
        private ComboBox cmbKategori;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
    }
}