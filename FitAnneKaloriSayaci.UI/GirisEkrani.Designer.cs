namespace FitAnneKaloriSayaci.UI
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.cbSifremiGoster = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBirtaneOlustur = new System.Windows.Forms.LinkLabel();
            this.lblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSifremiGoster
            // 
            this.cbSifremiGoster.AutoSize = true;
            this.cbSifremiGoster.Location = new System.Drawing.Point(137, 390);
            this.cbSifremiGoster.Name = "cbSifremiGoster";
            this.cbSifremiGoster.Size = new System.Drawing.Size(129, 25);
            this.cbSifremiGoster.TabIndex = 35;
            this.cbSifremiGoster.Text = "Şifremi Göster";
            this.cbSifremiGoster.UseVisualStyleBackColor = true;
            this.cbSifremiGoster.CheckedChanged += new System.EventHandler(this.cbSifremiGoster_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hesabınız yok mu ? ";
            // 
            // lblBirtaneOlustur
            // 
            this.lblBirtaneOlustur.AutoSize = true;
            this.lblBirtaneOlustur.Location = new System.Drawing.Point(245, 473);
            this.lblBirtaneOlustur.Name = "lblBirtaneOlustur";
            this.lblBirtaneOlustur.Size = new System.Drawing.Size(139, 21);
            this.lblBirtaneOlustur.TabIndex = 33;
            this.lblBirtaneOlustur.TabStop = true;
            this.lblBirtaneOlustur.Text = "Bir tane oluşturun!";
            this.lblBirtaneOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBirtaneOlustur_LinkClicked);
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.AutoSize = true;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(176, 520);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(126, 21);
            this.lblSifremiUnuttum.TabIndex = 32;
            this.lblSifremiUnuttum.TabStop = true;
            this.lblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSifremiUnuttum_LinkClicked);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(137, 324);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(208, 31);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Location = new System.Drawing.Point(137, 255);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PlaceholderText = "Örnek: .,/!?*-1234567890Aa";
            this.txtSifre.Size = new System.Drawing.Size(208, 29);
            this.txtSifre.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(137, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "E-mail : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(454, 631);
            this.Controls.Add(this.cbSifremiGoster);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBirtaneOlustur);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(470, 670);
            this.MinimumSize = new System.Drawing.Size(470, 670);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisEkrani_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbSifremiGoster;
        private Label label7;
        private LinkLabel lblBirtaneOlustur;
        private LinkLabel lblSifremiUnuttum;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}