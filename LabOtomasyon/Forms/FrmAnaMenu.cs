using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOtomasyon.Forms
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void FormGetir(Form frm)
        {
            panelContainer.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            frm.AutoScaleMode = AutoScaleMode.None;

            panelContainer.Controls.Add(frm);

            frm.Show();
        }

        private void btn_Hasta_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmHasta());
        }

        private void btn_Tahlil_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmTahlil());
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            FormGetir(new FrmPersonel());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();

            this.Close();
        }
    }
}
