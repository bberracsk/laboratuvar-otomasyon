using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LabOtomasyon.Database;
using LabOtomasyon.Interfaces;

namespace LabOtomasyon.Services
{
    public class PersonelService : ICrud, IPersonel
    {
        SqlConnection conn = DbConnection.Baglan();

        public void Ekle(string ad, string soyad, string gorev, string kullaniciAdi, string sifre)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO Personel " + "(Ad,Soyad,Gorev,KullaniciAdi,Sifre) " + "VALUES " + "(@ad,@soyad,@gorev,@kadi,@sifre)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@gorev", gorev);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Personel eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Listele()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = "SELECT * FROM Personel";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        public DataTable Ara(string aranan)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Personel " +"WHERE Ad LIKE @aranan " + "OR Soyad LIKE @aranan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue ("@aranan", "%" + aranan + "%");

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public void Guncelle(int id,string ad,string soyad,string gorev,string kullaniciAdi,string sifre)
        {
            try
            {
                conn.Open();

                string query =
                "UPDATE Personel SET " +"Ad=@ad, " +"Soyad=@soyad, " +"Gorev=@gorev, " + "KullaniciAdi=@kadi, " +"Sifre=@sifre " + "WHERE Id=@id";
                SqlCommand cmd =new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@gorev", gorev);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void Sil(int id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Personel WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Personel silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void PersonelBilgiGetir()
        {
            MessageBox.Show("Personel bilgileri");
        }



        void ICrud.Ekle()
        {

        }

        void ICrud.Listele()
        {

        }

        void ICrud.Ara(string veri)
        {

        }

        void ICrud.Guncelle()
        {

        }

        void ICrud.Sil()
        {

        }
    }
}