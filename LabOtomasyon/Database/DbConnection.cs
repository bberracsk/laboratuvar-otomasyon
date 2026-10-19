using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOtomasyon.Database
{
    public class DbConnection
    {

        public static string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LabOtomasyonDB;Integrated Security=True";

        public static SqlConnection Baglan()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
