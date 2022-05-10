using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=.\sqlexpress;Initial Catalog=QLPM;Integrated Security=True";
            //string s = @"Data Source=LAPTOP-UP3QC2F2;Initial Catalog=QLPM;User ID=sa;Password=sql2020";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            return conn;
        }

        public static void DongKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        public static DataTable TruyVanLayDuLieu(string query, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool TruyVanKhongLayDuLieu(string query, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
