using System;
using System.Windows.Forms;
using LabOtomasyon.Services;


namespace LabOtomasyon.Forms
{
    public partial class FrmPersonel : Form
    {

        PersonelService ps = new PersonelService();

        int secilenId = 0; 

        public FrmPersonel()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtGorev.Clear();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = ps.Listele();
            dgvPersonel.DataSource = ps.Listele();
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.MultiSelect = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ps.Ekle(txtAd.Text,txtSoyad.Text, txtGorev.Text,txtKullaniciAdi.Text,txtSifre.Text);
            dgvPersonel.DataSource = ps.Listele();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ps.Guncelle(secilenId,txtAd.Text,txtSoyad.Text, txtGorev.Text, txtKullaniciAdi.Text,txtSifre.Text);
            dgvPersonel.DataSource = ps.Listele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvPersonel.DataSource =ps.Ara(txtAra.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ps.Sil(secilenId);
            dgvPersonel.DataSource = ps.Listele();
            Temizle();
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId =Convert.ToInt32(dgvPersonel.CurrentRow.Cells["Id"].Value);

            txtAd.Text =dgvPersonel.CurrentRow.Cells["Ad"].Value.ToString();

            txtSoyad.Text = dgvPersonel.CurrentRow.Cells["Soyad"].Value.ToString();

            txtGorev.Text =dgvPersonel.CurrentRow.Cells["Gorev"].Value.ToString();

            txtKullaniciAdi.Text =dgvPersonel.CurrentRow.Cells["KullaniciAdi"].Value.ToString();

            txtSifre.Text = dgvPersonel.CurrentRow.Cells["Sifre"].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
