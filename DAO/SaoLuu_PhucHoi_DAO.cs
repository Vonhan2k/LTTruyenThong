using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SaoLuu_PhucHoi_DAO
    {
        static SqlConnection conn;

        public static bool SaoLuu(string link)
        {
            string vitri = "\\QLPM(" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + ").bak";
            string query = "BACKUP DATABASE QLPM TO DISK = N'" + link + vitri + "'";
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }

        public static bool PhucHoi(string path, string database, string severname, string user, string password)
        {
            string cmd = "alter database " + database + " set offline with rollback immediate " +
            "restore database " + database + " from disk = '" + path + "' with replace " +
            "alter database " + database + " set online";
            string Con_string = "";
            if (user == "" && password == "")
            {
                Con_string = "Data Source=" + severname + ";Integrated Security=True";
            }
            else
            {
                Con_string = @"Data Source = " + severname + "; Password =" + password + "; User = " + user + ";";
            }
            try
            {
                SqlConnection con = new SqlConnection(Con_string);
                con.Open();
                SqlCommand cm = new SqlCommand(cmd, con);
                cm.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
