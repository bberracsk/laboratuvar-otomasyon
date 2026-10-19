namespace LabOtomasyon.Forms
{
    partial class FrmTahlil
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
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.dgvTahlil = new System.Windows.Forms.DataGridView();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTahlilAdi = new System.Windows.Forms.Label();
            this.lblHastaAdSoyad = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbTahlil = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTahlil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(496, 117);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(200, 22);
            this.txtSonuc.TabIndex = 46;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(436, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 42;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(118, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 39;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(441, 120);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(45, 16);
            this.lblSonuc.TabIndex = 38;
            this.lblSonuc.Text = "Sonuç";
            // 
            // dgvTahlil
            // 
            this.dgvTahlil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTahlil.Location = new System.Drawing.Point(12, 175);
            this.dgvTahlil.Name = "dgvTahlil";
            this.dgvTahlil.RowHeadersWidth = 51;
            this.dgvTahlil.RowTemplate.Height = 24;
            this.dgvTahlil.Size = new System.Drawing.Size(1167, 502);
            this.dgvTahlil.TabIndex = 37;
            this.dgvTahlil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTahlil_CellClick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(441, 77);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 36;
            this.lblTarih.Text = "Tarih";
            // 
            // lblTahlilAdi
            // 
            this.lblTahlilAdi.AutoSize = true;
            this.lblTahlilAdi.Location = new System.Drawing.Point(29, 120);
            this.lblTahlilAdi.Name = "lblTahlilAdi";
            this.lblTahlilAdi.Size = new System.Drawing.Size(63, 16);
            this.lblTahlilAdi.TabIndex = 35;
            this.lblTahlilAdi.Text = "Tahlil Adı";
            // 
            // lblHastaAdSoyad
            // 
            this.lblHastaAdSoyad.AutoSize = true;
            this.lblHastaAdSoyad.Location = new System.Drawing.Point(29, 77);
            this.lblHastaAdSoyad.Name = "lblHastaAdSoyad";
            this.lblHastaAdSoyad.Size = new System.Drawing.Size(112, 16);
            this.lblHastaAdSoyad.TabIndex = 34;
            this.lblHastaAdSoyad.Text = "Hasta Adı Soyadı";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(147, 69);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(208, 24);
            this.cmbHasta.TabIndex = 47;
            // 
            // cmbTahlil
            // 
            this.cmbTahlil.FormattingEnabled = true;
            this.cmbTahlil.Location = new System.Drawing.Point(147, 112);
            this.cmbTahlil.Name = "cmbTahlil";
            this.cmbTahlil.Size = new System.Drawing.Size(208, 24);
            this.cmbTahlil.TabIndex = 48;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(496, 71);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 49;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(542, 11);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(637, 22);
            this.txtAra.TabIndex = 50;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(330, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 23);
            this.btnTemizle.TabIndex = 51;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmTahlil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 689);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbTahlil);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.dgvTahlil);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTahlilAdi);
            this.Controls.Add(this.lblHastaAdSoyad);
            this.Name = "FrmTahlil";
            this.Text = "Tahlil İşlemleri";
            this.Load += new System.EventHandler(this.FrmTahlil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTahlil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.DataGridView dgvTahlil;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTahlilAdi;
        private System.Windows.Forms.Label lblHastaAdSoyad;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbTahlil;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnTemizle;
    }
}