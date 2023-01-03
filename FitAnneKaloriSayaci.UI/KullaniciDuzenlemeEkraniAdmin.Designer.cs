namespace FitAnneKaloriSayaci.UI
{
    partial class KullaniciDuzenlemeEkraniAdmin
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.grbSifreBilgiler = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSifreTekrari = new System.Windows.Forms.TextBox();
            this.grbİletisimBilgiler = new System.Windows.Forms.GroupBox();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.nudHamilelikKacinciHafta = new System.Windows.Forms.NumericUpDown();
            this.lblHamilelikHaftasi = new System.Windows.Forms.Label();
            this.rbtnDogumSonrasi = new System.Windows.Forms.RadioButton();
            this.rbtnHamileyim = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKilo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBoy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.grbSifreBilgiler.SuspendLayout();
            this.grbİletisimBilgiler.SuspendLayout();
            this.grpKisiselBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHamilelikKacinciHafta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(878, 200);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 38);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(878, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(165, 38);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(878, 284);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(165, 38);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(21, 438);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowTemplate.Height = 25;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(1022, 300);
            this.dgvKullanicilar.TabIndex = 26;
            this.dgvKullanicilar.Click += new System.EventHandler(this.dgvKullanicilar_Click);
            // 
            // grbSifreBilgiler
            // 
            this.grbSifreBilgiler.Controls.Add(this.txtSifre);
            this.grbSifreBilgiler.Controls.Add(this.label10);
            this.grbSifreBilgiler.Controls.Add(this.label11);
            this.grbSifreBilgiler.Controls.Add(this.label12);
            this.grbSifreBilgiler.Controls.Add(this.txtSifreTekrari);
            this.grbSifreBilgiler.Location = new System.Drawing.Point(483, 231);
            this.grbSifreBilgiler.Name = "grbSifreBilgiler";
            this.grbSifreBilgiler.Size = new System.Drawing.Size(365, 177);
            this.grbSifreBilgiler.TabIndex = 25;
            this.grbSifreBilgiler.TabStop = false;
            this.grbSifreBilgiler.Text = "Şifre Bilgileri";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Location = new System.Drawing.Point(141, 41);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 29);
            this.txtSifre.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Şifre : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Şifre Tekrarı :";
            // 
            // txtSifreTekrari
            // 
            this.txtSifreTekrari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreTekrari.Location = new System.Drawing.Point(141, 86);
            this.txtSifreTekrari.Name = "txtSifreTekrari";
            this.txtSifreTekrari.Size = new System.Drawing.Size(200, 29);
            this.txtSifreTekrari.TabIndex = 10;
            // 
            // grbİletisimBilgiler
            // 
            this.grbİletisimBilgiler.Controls.Add(this.txtTelefonNo);
            this.grbİletisimBilgiler.Controls.Add(this.label7);
            this.grbİletisimBilgiler.Controls.Add(this.label8);
            this.grbİletisimBilgiler.Controls.Add(this.label9);
            this.grbİletisimBilgiler.Controls.Add(this.txtEmail);
            this.grbİletisimBilgiler.Location = new System.Drawing.Point(483, 26);
            this.grbİletisimBilgiler.Name = "grbİletisimBilgiler";
            this.grbİletisimBilgiler.Size = new System.Drawing.Size(365, 184);
            this.grbİletisimBilgiler.TabIndex = 24;
            this.grbİletisimBilgiler.TabStop = false;
            this.grbİletisimBilgiler.Text = "İletişim Bilgiler";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonNo.Location = new System.Drawing.Point(141, 55);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(200, 29);
            this.txtTelefonNo.TabIndex = 7;
            this.txtTelefonNo.Click += new System.EventHandler(this.txtTelefonNo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon No : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "E-mail :";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(141, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // grpKisiselBilgiler
            // 
            this.grpKisiselBilgiler.Controls.Add(this.nudHamilelikKacinciHafta);
            this.grpKisiselBilgiler.Controls.Add(this.lblHamilelikHaftasi);
            this.grpKisiselBilgiler.Controls.Add(this.rbtnDogumSonrasi);
            this.grpKisiselBilgiler.Controls.Add(this.rbtnHamileyim);
            this.grpKisiselBilgiler.Controls.Add(this.txtAd);
            this.grpKisiselBilgiler.Controls.Add(this.label6);
            this.grpKisiselBilgiler.Controls.Add(this.label1);
            this.grpKisiselBilgiler.Controls.Add(this.nudKilo);
            this.grpKisiselBilgiler.Controls.Add(this.label2);
            this.grpKisiselBilgiler.Controls.Add(this.nudBoy);
            this.grpKisiselBilgiler.Controls.Add(this.label3);
            this.grpKisiselBilgiler.Controls.Add(this.dtpDogumTarihi);
            this.grpKisiselBilgiler.Controls.Add(this.label4);
            this.grpKisiselBilgiler.Controls.Add(this.txtSoyad);
            this.grpKisiselBilgiler.Controls.Add(this.label5);
            this.grpKisiselBilgiler.Location = new System.Drawing.Point(21, 22);
            this.grpKisiselBilgiler.Name = "grpKisiselBilgiler";
            this.grpKisiselBilgiler.Size = new System.Drawing.Size(442, 386);
            this.grpKisiselBilgiler.TabIndex = 23;
            this.grpKisiselBilgiler.TabStop = false;
            this.grpKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // nudHamilelikKacinciHafta
            // 
            this.nudHamilelikKacinciHafta.Location = new System.Drawing.Point(311, 308);
            this.nudHamilelikKacinciHafta.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudHamilelikKacinciHafta.Name = "nudHamilelikKacinciHafta";
            this.nudHamilelikKacinciHafta.Size = new System.Drawing.Size(76, 29);
            this.nudHamilelikKacinciHafta.TabIndex = 6;
            this.nudHamilelikKacinciHafta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHamilelikHaftasi
            // 
            this.lblHamilelikHaftasi.AutoSize = true;
            this.lblHamilelikHaftasi.Location = new System.Drawing.Point(21, 316);
            this.lblHamilelikHaftasi.Name = "lblHamilelikHaftasi";
            this.lblHamilelikHaftasi.Size = new System.Drawing.Size(204, 21);
            this.lblHamilelikHaftasi.TabIndex = 15;
            this.lblHamilelikHaftasi.Text = "Hamileliğin Kaçıncı Haftası : ";
            // 
            // rbtnDogumSonrasi
            // 
            this.rbtnDogumSonrasi.AutoSize = true;
            this.rbtnDogumSonrasi.Location = new System.Drawing.Point(251, 267);
            this.rbtnDogumSonrasi.Name = "rbtnDogumSonrasi";
            this.rbtnDogumSonrasi.Size = new System.Drawing.Size(136, 25);
            this.rbtnDogumSonrasi.TabIndex = 14;
            this.rbtnDogumSonrasi.Text = "Doğum Sonrası";
            this.rbtnDogumSonrasi.UseVisualStyleBackColor = true;
            this.rbtnDogumSonrasi.CheckedChanged += new System.EventHandler(this.rbtnDogumSonrasi_CheckedChanged);
            // 
            // rbtnHamileyim
            // 
            this.rbtnHamileyim.AutoSize = true;
            this.rbtnHamileyim.Checked = true;
            this.rbtnHamileyim.Location = new System.Drawing.Point(76, 267);
            this.rbtnHamileyim.Name = "rbtnHamileyim";
            this.rbtnHamileyim.Size = new System.Drawing.Size(103, 25);
            this.rbtnHamileyim.TabIndex = 13;
            this.rbtnHamileyim.TabStop = true;
            this.rbtnHamileyim.Text = "Hamileyim";
            this.rbtnHamileyim.UseVisualStyleBackColor = true;
            this.rbtnHamileyim.CheckedChanged += new System.EventHandler(this.rbtnHamileyim_CheckedChanged);
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Location = new System.Drawing.Point(187, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(239, 29);
            this.txtAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 2;
            // 
            // nudKilo
            // 
            this.nudKilo.Location = new System.Drawing.Point(187, 201);
            this.nudKilo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudKilo.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudKilo.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudKilo.Name = "nudKilo";
            this.nudKilo.Size = new System.Drawing.Size(103, 29);
            this.nudKilo.TabIndex = 5;
            this.nudKilo.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad :";
            // 
            // nudBoy
            // 
            this.nudBoy.Location = new System.Drawing.Point(187, 159);
            this.nudBoy.Margin = new System.Windows.Forms.Padding(4);
            this.nudBoy.Maximum = new decimal(new int[] {
            215,
            0,
            0,
            0});
            this.nudBoy.Minimum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.nudBoy.Name = "nudBoy";
            this.nudBoy.Size = new System.Drawing.Size(103, 29);
            this.nudBoy.TabIndex = 4;
            this.nudBoy.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(187, 117);
            this.dtpDogumTarihi.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1982, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(239, 29);
            this.dtpDogumTarihi.TabIndex = 3;
            this.dtpDogumTarihi.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Boy  (cm): ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Location = new System.Drawing.Point(187, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(239, 29);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kilo (kg): ";
            // 
            // KullaniciDuzenlemeEkraniAdmin
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.grbSifreBilgiler);
            this.Controls.Add(this.grbİletisimBilgiler);
            this.Controls.Add(this.grpKisiselBilgiler);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "KullaniciDuzenlemeEkraniAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı-Admin Kullanıcı Düzenleme Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciDuzenlemeEkrani_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.grbSifreBilgiler.ResumeLayout(false);
            this.grbSifreBilgiler.PerformLayout();
            this.grbİletisimBilgiler.ResumeLayout(false);
            this.grbİletisimBilgiler.PerformLayout();
            this.grpKisiselBilgiler.ResumeLayout(false);
            this.grpKisiselBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHamilelikKacinciHafta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private DataGridView dgvKullanicilar;
        private GroupBox grbSifreBilgiler;
        private TextBox txtSifre;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtSifreTekrari;
        private GroupBox grbİletisimBilgiler;
        private MaskedTextBox txtTelefonNo;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtEmail;
        private GroupBox grpKisiselBilgiler;
        private NumericUpDown nudHamilelikKacinciHafta;
        private Label lblHamilelikHaftasi;
        private RadioButton rbtnDogumSonrasi;
        private RadioButton rbtnHamileyim;
        private TextBox txtAd;
        private Label label6;
        private Label label1;
        private NumericUpDown nudKilo;
        private Label label2;
        private NumericUpDown nudBoy;
        private Label label3;
        private DateTimePicker dtpDogumTarihi;
        private Label label4;
        private TextBox txtSoyad;
        private Label label5;
    }
}