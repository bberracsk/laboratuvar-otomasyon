using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabOtomasyon.Database;
using LabOtomasyon.Interfaces;

namespace LabOtomasyon.Services
{
    public class TahlilService : ITahlil
    {
        SqlConnection conn = DbConnection.Baglan();

        public void Ekle(int hastaId, int tahlilTurId, string sonuc, DateTime tarih)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO Tahlil(HastaId,TahlilTurId,Sonuc,Tarih) " + "VALUES(@h,@t,@s,@d)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@h", hastaId);
                cmd.Parameters.AddWithValue("@t", tahlilTurId);
                cmd.Parameters.AddWithValue("@s", sonuc);
                cmd.Parameters.AddWithValue("@d", tarih);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tahlil eklendi");
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

                string query =
                @"SELECT t.Id,h.Ad + ' ' + h.Soyad AS Hasta,tt.TahlilAdi,t.Sonuc,t.Tarih FROM Tahlil t
                  INNER JOIN Hastalar h ON t.HastaId = h.Id
                  INNER JOIN TahlilTurleri tt ON t.TahlilTurId = tt.Id";

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


        public void SonucGetir()
        {

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
