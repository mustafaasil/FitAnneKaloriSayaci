namespace FitAnneKaloriSayaci.UI
{
    partial class RaporAlEkrani
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEnCok = new System.Windows.Forms.DataGridView();
            this.btnEnCokTuketilenUrun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.grbGunSonuRaporu = new System.Windows.Forms.GroupBox();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblAlmanGerekenKalori = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAraOgun = new System.Windows.Forms.Label();
            this.lblAksam = new System.Windows.Forms.Label();
            this.lblOglen = new System.Windows.Forms.Label();
            this.lblSabah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbGunSonuRaporu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEnCok);
            this.groupBox2.Controls.Add(this.btnEnCokTuketilenUrun);
            this.groupBox2.Location = new System.Drawing.Point(12, 491);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En Çok Tüketilen Besin";
            // 
            // dgvEnCok
            // 
            this.dgvEnCok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnCok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnCok.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnCok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCok.Location = new System.Drawing.Point(38, 28);
            this.dgvEnCok.MultiSelect = false;
            this.dgvEnCok.Name = "dgvEnCok";
            this.dgvEnCok.ReadOnly = true;
            this.dgvEnCok.RowTemplate.Height = 25;
            this.dgvEnCok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnCok.Size = new System.Drawing.Size(240, 98);
            this.dgvEnCok.TabIndex = 1;
            // 
            // btnEnCokTuketilenUrun
            // 
            this.btnEnCokTuketilenUrun.Location = new System.Drawing.Point(300, 43);
            this.btnEnCokTuketilenUrun.Name = "btnEnCokTuketilenUrun";
            this.btnEnCokTuketilenUrun.Size = new System.Drawing.Size(201, 72);
            this.btnEnCokTuketilenUrun.TabIndex = 0;
            this.btnEnCokTuketilenUrun.Text = "En Çok Tercih Edilen Ürünü Getir";
            this.btnEnCokTuketilenUrun.UseVisualStyleBackColor = true;
            this.btnEnCokTuketilenUrun.Click += new System.EventHandler(this.btnEnCokTuketilenUrun_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rapor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 11;
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaporlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRaporlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlar.Location = new System.Drawing.Point(551, 65);
            this.dgvRaporlar.MultiSelect = false;
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.ReadOnly = true;
            this.dgvRaporlar.RowTemplate.Height = 25;
            this.dgvRaporlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaporlar.Size = new System.Drawing.Size(554, 570);
            this.dgvRaporlar.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süreç Raporu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bitiş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Başlangıç :";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(118, 96);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(234, 29);
            this.dtpBitis.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(118, 40);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(234, 29);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // grbGunSonuRaporu
            // 
            this.grbGunSonuRaporu.Controls.Add(this.lblUyari);
            this.grbGunSonuRaporu.Controls.Add(this.lblAlmanGerekenKalori);
            this.grbGunSonuRaporu.Controls.Add(this.label11);
            this.grbGunSonuRaporu.Controls.Add(this.lblToplamKalori);
            this.grbGunSonuRaporu.Controls.Add(this.label9);
            this.grbGunSonuRaporu.Controls.Add(this.lblAraOgun);
            this.grbGunSonuRaporu.Controls.Add(this.lblAksam);
            this.grbGunSonuRaporu.Controls.Add(this.lblOglen);
            this.grbGunSonuRaporu.Controls.Add(this.lblSabah);
            this.grbGunSonuRaporu.Controls.Add(this.label4);
            this.grbGunSonuRaporu.Controls.Add(this.label3);
            this.grbGunSonuRaporu.Controls.Add(this.label2);
            this.grbGunSonuRaporu.Controls.Add(this.label1);
            this.grbGunSonuRaporu.Location = new System.Drawing.Point(12, 25);
            this.grbGunSonuRaporu.Name = "grbGunSonuRaporu";
            this.grbGunSonuRaporu.Size = new System.Drawing.Size(519, 270);
            this.grbGunSonuRaporu.TabIndex = 7;
            this.grbGunSonuRaporu.TabStop = false;
            this.grbGunSonuRaporu.Text = "Gün Sonu Raporu";
            // 
            // lblUyari
            // 
            this.lblUyari.Location = new System.Drawing.Point(280, 166);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(221, 69);
            this.lblUyari.TabIndex = 12;
            this.lblUyari.Text = "...";
            this.lblUyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlmanGerekenKalori
            // 
            this.lblAlmanGerekenKalori.AutoSize = true;
            this.lblAlmanGerekenKalori.Location = new System.Drawing.Point(359, 96);
            this.lblAlmanGerekenKalori.Name = "lblAlmanGerekenKalori";
            this.lblAlmanGerekenKalori.Size = new System.Drawing.Size(19, 21);
            this.lblAlmanGerekenKalori.TabIndex = 11;
            this.lblAlmanGerekenKalori.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Günlük Alman Grereken Kalori";
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.Location = new System.Drawing.Point(182, 214);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(19, 21);
            this.lblToplamKalori.TabIndex = 9;
            this.lblToplamKalori.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam Alınan Kalori : ";
            // 
            // lblAraOgun
            // 
            this.lblAraOgun.AutoSize = true;
            this.lblAraOgun.Location = new System.Drawing.Point(181, 150);
            this.lblAraOgun.Name = "lblAraOgun";
            this.lblAraOgun.Size = new System.Drawing.Size(19, 21);
            this.lblAraOgun.TabIndex = 7;
            this.lblAraOgun.Text = "0";
            // 
            // lblAksam
            // 
            this.lblAksam.AutoSize = true;
            this.lblAksam.Location = new System.Drawing.Point(182, 112);
            this.lblAksam.Name = "lblAksam";
            this.lblAksam.Size = new System.Drawing.Size(19, 21);
            this.lblAksam.TabIndex = 6;
            this.lblAksam.Text = "0";
            // 
            // lblOglen
            // 
            this.lblOglen.AutoSize = true;
            this.lblOglen.Location = new System.Drawing.Point(181, 76);
            this.lblOglen.Name = "lblOglen";
            this.lblOglen.Size = new System.Drawing.Size(19, 21);
            this.lblOglen.TabIndex = 5;
            this.lblOglen.Text = "0";
            // 
            // lblSabah
            // 
            this.lblSabah.AutoSize = true;
            this.lblSabah.Location = new System.Drawing.Point(181, 40);
            this.lblSabah.Name = "lblSabah";
            this.lblSabah.Size = new System.Drawing.Size(19, 21);
            this.lblSabah.TabIndex = 4;
            this.lblSabah.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ara Öğün : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Akşam : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğlen : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabah : ";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(426, 373);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(87, 69);
            this.btnGetir.TabIndex = 14;
            this.btnGetir.Text = "Raporları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // RaporAlEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1117, 684);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvRaporlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbGunSonuRaporu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1133, 723);
            this.MinimumSize = new System.Drawing.Size(1133, 723);
            this.Name = "RaporAlEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaporAlEkrani_FormClosed);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbGunSonuRaporu.ResumeLayout(false);
            this.grbGunSonuRaporu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private DataGridView dgvRaporlar;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private GroupBox grbGunSonuRaporu;
        private Label lblUyari;
        private Label lblAlmanGerekenKalori;
        private Label label11;
        private Label lblToplamKalori;
        private Label label9;
        private Label lblAraOgun;
        private Label lblAksam;
        private Label lblOglen;
        private Label lblSabah;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGetir;
        private Button btnEnCokTuketilenUrun;
        private DataGridView dgvEncok;
        private DataGridView dgvEnCok;
    }
}