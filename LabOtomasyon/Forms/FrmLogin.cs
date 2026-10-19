using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LabOtomasyon.Database;

namespace LabOtomasyon.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbConnection.Baglan();

            try
            {
                conn.Open();

                string query ="SELECT COUNT(*) FROM Personel " + "WHERE KullaniciAdi=@kadi AND Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@kadi", txt_kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    MessageBox.Show("Giriş başarılı");

                    FrmAnaMenu frm = new FrmAnaMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
