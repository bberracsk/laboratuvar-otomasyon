using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Services;

namespace LabOtomasyon.Forms
{
    public partial class FrmHasta : Form
    {

        HastaService hs = new HastaService();

        int secilenId = 0;
        public FrmHasta()
        {
            InitializeComponent();

        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            dgvHasta.DataSource = hs.Listele();

            dgvHasta.DataSource = hs.Listele();


            dgvHasta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHasta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHasta.MultiSelect = false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            hs.Ekle( txtAd.Text, txtSoyad.Text, txtTc.Text, txtTelefon.Text);
            dgvHasta.DataSource = hs.Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            hs.Guncelle(secilenId, txtAd.Text, txtSoyad.Text, txtTc.Text, txtTelefon.Text);
            dgvHasta.DataSource = hs.Listele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvHasta.DataSource = hs.Ara(txtAra.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            hs.Sil(secilenId);
            dgvHasta.DataSource = hs.Listele();
            Temizle();
        }

        private void dgvHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId =
            Convert.ToInt32( dgvHasta.CurrentRow.Cells["Id"].Value);
            txtAd.Text = dgvHasta.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyad.Text = dgvHasta.CurrentRow.Cells["Soyad"].Value.ToString();
            txtTc.Text = dgvHasta.CurrentRow.Cells["TcNo"].Value.ToString();
            txtTelefon.Text = dgvHasta.CurrentRow.Cells["Telefon"].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
