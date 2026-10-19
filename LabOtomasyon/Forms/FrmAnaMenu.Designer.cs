namespace LabOtomasyon.Forms
{
    partial class FrmAnaMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btn_Hasta = new System.Windows.Forms.Button();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.btn_Tahlil = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btn_Hasta);
            this.panelMenu.Controls.Add(this.btn_Personel);
            this.panelMenu.Controls.Add(this.btn_Tahlil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1104, 53);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(825, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(268, 47);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btn_Hasta
            // 
            this.btn_Hasta.Location = new System.Drawing.Point(3, 3);
            this.btn_Hasta.Name = "btn_Hasta";
            this.btn_Hasta.Size = new System.Drawing.Size(268, 47);
            this.btn_Hasta.TabIndex = 0;
            this.btn_Hasta.Text = "Hasta İşlemleri";
            this.btn_Hasta.UseVisualStyleBackColor = true;
            this.btn_Hasta.Click += new System.EventHandler(this.btn_Hasta_Click);
            // 
            // btn_Personel
            // 
            this.btn_Personel.Location = new System.Drawing.Point(551, 3);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(268, 47);
            this.btn_Personel.TabIndex = 1;
            this.btn_Personel.Text = "Personel İşlemleri";
            this.btn_Personel.UseVisualStyleBackColor = true;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // btn_Tahlil
            // 
            this.btn_Tahlil.Location = new System.Drawing.Point(277, 3);
            this.btn_Tahlil.Name = "btn_Tahlil";
            this.btn_Tahlil.Size = new System.Drawing.Size(268, 47);
            this.btn_Tahlil.TabIndex = 2;
            this.btn_Tahlil.Text = "Tahlil İşlemleri";
            this.btn_Tahlil.UseVisualStyleBackColor = true;
            this.btn_Tahlil.Click += new System.EventHandler(this.btn_Tahlil_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 53);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1104, 595);
            this.panelContainer.TabIndex = 1;
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 648);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmAnaMenu";
            this.Text = "Ana Sayfa";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Tahlil;
        private System.Windows.Forms.Button btn_Hasta;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCikis;
    }
}