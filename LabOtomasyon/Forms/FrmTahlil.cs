using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LabOtomasyon.Database;
using LabOtomasyon.Services;

namespace LabOtomasyon.Forms
{
    public partial class FrmTahlil : Form
    {

        TahlilService ts = new TahlilService();
        int secilenId = 0;

        public FrmTahlil()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            cmbHasta.SelectedIndex = 0;
            cmbTahlil.SelectedIndex = 0;
            txtSonuc.Clear();
            dtpTarih.Value = DateTime.Now;

            secilenId = 0;
        }

        private void FrmTahlil_Load(object sender, EventArgs e)
        {
            dgvTahlil.DataSource = ts.Listele();
            dgvTahlil.DataSource = ts.Listele();

            dgvTahlil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTahlil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTahlil.MultiSelect = false;

            SqlConnection conn = DbConnection.Baglan();


            SqlDataAdapter da1 = new SqlDataAdapter( "SELECT Id, Ad + ' ' + Soyad AS AdSoyad FROM Hastalar", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmbHasta.DisplayMember = "AdSoyad";
            cmbHasta.ValueMember = "Id";
            cmbHasta.DataSource = dt1;


            SqlDataAdapter da2 = new SqlDataAdapter("SELECT Id, TahlilAdi FROM TahlilTurleri", conn);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cmbTahlil.DisplayMember = "TahlilAdi";
            cmbTahlil.ValueMember = "Id";
            cmbTahlil.DataSource = dt2;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ts.Ekle(Convert.ToInt32(cmbHasta.SelectedValue),Convert.ToInt32(cmbTahlil.SelectedValue),txtSonuc.Text, dtpTarih.Value );
            dgvTahlil.DataSource = ts.Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbConnection.Baglan();

            conn.Open();

            string query ="UPDATE Tahlil SET " + "HastaId=@h, " + "TahlilTurId=@t, " + "Sonuc=@s, " +"Tarih=@d " + "WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", secilenId);
            cmd.Parameters.AddWithValue("@h", cmbHasta.SelectedValue);
            cmd.Parameters.AddWithValue("@t", cmbTahlil.SelectedValue);
            cmd.Parameters.AddWithValue("@s", txtSonuc.Text);
            cmd.Parameters.AddWithValue("@d", dtpTarih.Value);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Tahlil güncellendi");

            dgvTahlil.DataSource = ts.Listele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbConnection.Baglan();

            conn.Open();

            string query =
            @"SELECT t.Id,h.Ad + ' ' + h.Soyad AS Hasta,tt.TahlilAdi,t.Sonuc, t.Tarih
            FROM Tahlil t
            INNER JOIN Hastalar h ON t.HastaId = h.Id
            INNER JOIN TahlilTurleri tt ON t.TahlilTurId = tt.Id
            WHERE h.Ad LIKE @a OR h.Soyad LIKE @a";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@a", "%" + txtAra.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvTahlil.DataSource = dt;

            conn.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbConnection.Baglan();
            conn.Open();
            string query = "DELETE FROM Tahlil WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", secilenId);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Tahlil silindi");
            dgvTahlil.DataSource = ts.Listele();
            Temizle();
        }

        private void dgvTahlil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = Convert.ToInt32( dgvTahlil.CurrentRow.Cells["Id"].Value);

            cmbHasta.Text =dgvTahlil.CurrentRow.Cells["Hasta"].Value.ToString();

            cmbTahlil.Text = dgvTahlil.CurrentRow.Cells["TahlilAdi"].Value.ToString();

            txtSonuc.Text = dgvTahlil.CurrentRow.Cells["Sonuc"].Value.ToString();

            dtpTarih.Value = Convert.ToDateTime(dgvTahlil.CurrentRow.Cells["Tarih"].Value);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
