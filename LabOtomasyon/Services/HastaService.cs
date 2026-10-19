using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Interfaces;
using LabOtomasyon.Database;

namespace LabOtomasyon.Services
{
    public class HastaService: ICrud, IHasta
    {
        SqlConnection conn = DbConnection.Baglan();


        public void Ekle(string ad, string soyad,string tc, string telefon)
        {
            try
            {
                conn.Open();

                string query =
                "INSERT INTO Hastalar(Ad,Soyad,TcNo,Telefon) " + "VALUES(@ad,@soyad,@tc,@telefon)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@telefon", telefon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hasta eklendi");
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
                string query = "SELECT * FROM Hastalar";
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

                string query = "SELECT * FROM Hastalar " + "WHERE Ad LIKE @aranan " + "OR Soyad LIKE @aranan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@aranan", "%" + aranan + "%");
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



        public DataTable Ara(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query ="SELECT * FROM Hastalar WHERE Id=@id";
                SqlDataAdapter da =new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", id);
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

        public void Guncelle(int id, string ad, string soyad, string tc, string telefon)
        {
            try
            {
                conn.Open();

                string query = "UPDATE Hastalar SET " + "Ad=@ad, " + "Soyad=@soyad, " + "TcNo=@tc, " + "Telefon=@telefon " + "WHERE Id=@id";
                 SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@telefon", telefon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hasta güncellendi");
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
                string query ="DELETE FROM Hastalar WHERE Id=@id";
                SqlCommand cmd =new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hasta silindi");
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


        public void HastaBilgiGetir()
        {
            MessageBox.Show("Hasta bilgileri getirildi");
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

