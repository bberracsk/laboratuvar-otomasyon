namespace LabOtomasyon.Forms
{
    partial class FrmLogin
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
            this.grb_login = new System.Windows.Forms.GroupBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.grb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_login
            // 
            this.grb_login.Controls.Add(this.txt_sifre);
            this.grb_login.Controls.Add(this.txt_kullaniciadi);
            this.grb_login.Controls.Add(this.lblsifre);
            this.grb_login.Controls.Add(this.lbl_kullaniciadi);
            this.grb_login.Controls.Add(this.btn_giris);
            this.grb_login.Location = new System.Drawing.Point(108, 65);
            this.grb_login.Name = "grb_login";
            this.grb_login.Size = new System.Drawing.Size(488, 413);
            this.grb_login.TabIndex = 0;
            this.grb_login.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(178, 149);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(189, 22);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(178, 86);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(189, 22);
            this.txt_kullaniciadi.TabIndex = 3;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(83, 152);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(34, 16);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Şifre";
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(83, 89);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(79, 16);
            this.lbl_kullaniciadi.TabIndex = 1;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(86, 215);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(281, 33);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 583);
            this.Controls.Add(this.grb_login);
            this.Name = "FrmLogin";
            this.Text = "Login Sayfası";
            this.grb_login.ResumeLayout(false);
            this.grb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_login;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Button btn_giris;
    }
}