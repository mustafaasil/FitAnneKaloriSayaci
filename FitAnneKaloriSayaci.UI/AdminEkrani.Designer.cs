namespace FitAnneKaloriSayaci.UI
{
    partial class AdminEkrani
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bilgiGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiGüncellemeToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(486, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bilgiGüncellemeToolStripMenuItem
            // 
            this.bilgiGüncellemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KullanıcıToolStripMenuItem});
            this.bilgiGüncellemeToolStripMenuItem.Name = "bilgiGüncellemeToolStripMenuItem";
            this.bilgiGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.bilgiGüncellemeToolStripMenuItem.Text = "Bilgi Güncelleme";
            // 
            // KullanıcıToolStripMenuItem
            // 
            this.KullanıcıToolStripMenuItem.Name = "KullanıcıToolStripMenuItem";
            this.KullanıcıToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.KullanıcıToolStripMenuItem.Text = "Kullanıcı";
            this.KullanıcıToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KategoriToolStripMenuItem,
            this.UrunToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // KategoriToolStripMenuItem
            // 
            this.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem";
            this.KategoriToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.KategoriToolStripMenuItem.Text = "Kategori";
            this.KategoriToolStripMenuItem.Click += new System.EventHandler(this.KategoriToolStripMenuItem_Click);
            // 
            // UrunToolStripMenuItem
            // 
            this.UrunToolStripMenuItem.Name = "UrunToolStripMenuItem";
            this.UrunToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.UrunToolStripMenuItem.Text = "Ürün";
            this.UrunToolStripMenuItem.Click += new System.EventHandler(this.UrunToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 98);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Ekranına Hoşgeldiniz!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(486, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(502, 274);
            this.MinimumSize = new System.Drawing.Size(502, 274);
            this.Name = "AdminEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı-Admin Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminEkrani_FormClosed);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem bilgiGüncellemeToolStripMenuItem;
        private ToolStripMenuItem KullanıcıToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem KategoriToolStripMenuItem;
        private ToolStripMenuItem UrunToolStripMenuItem;
        private Label label2;
    }
}