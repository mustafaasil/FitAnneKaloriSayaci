namespace FitAnneKaloriSayaci.UI
{
    partial class SifreHatirlatma
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
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSifreGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonNo.Location = new System.Drawing.Point(189, 65);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(220, 29);
            this.txtTelefonNo.TabIndex = 37;
            this.txtTelefonNo.Click += new System.EventHandler(this.txtTelefonNo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefon No :";
            // 
            // btnSifreGoster
            // 
            this.btnSifreGoster.Location = new System.Drawing.Point(189, 122);
            this.btnSifreGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifreGoster.Name = "btnSifreGoster";
            this.btnSifreGoster.Size = new System.Drawing.Size(220, 50);
            this.btnSifreGoster.TabIndex = 35;
            this.btnSifreGoster.Text = "ŞİFRE GÖSTER";
            this.btnSifreGoster.UseVisualStyleBackColor = true;
            this.btnSifreGoster.Click += new System.EventHandler(this.btnSifreGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Şifrenizi görmek için, lütfen telefonunuzu yazınız";
            // 
            // SifreHatirlatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(454, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSifreGoster);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(470, 240);
            this.MinimumSize = new System.Drawing.Size(470, 240);
            this.Name = "SifreHatirlatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitAnne : Kalori Sayacı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SifreHatirlatma_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtTelefonNo;
        private Label label5;
        private Button btnSifreGoster;
        private Label label1;
    }
}