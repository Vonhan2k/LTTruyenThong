using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO 
{
    public class Account_DAO
    {
        static SqlConnection conn;

        public static List<Account_DTO> LayDSTaiKhoan()
        {
            string query = "select * from Account";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
                return null;
            List<Account_DTO> lstAccount = new List<Account_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Account_DTO acc = new Account_DTO();
                acc.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                acc.TenHienThi = dt.Rows[i]["TenHienThi"].ToString();
                acc.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                acc.Loai = int.Parse(dt.Rows[i]["Loai"].ToString());
                lstAccount.Add(acc);
            }
            DataProvider.DongKetNoi(conn);
            return lstAccount;
        }

        public static Account_DTO LayAccount(string tendangnhap, string matkhau)
        {
            string query = string.Format(@"select * from Account where TenDangNhap= '{0}' and MatKhau='{1}'", tendangnhap, matkhau);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Account_DTO acc = new Account_DTO();
            acc.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            acc.TenHienThi = dt.Rows[0]["TenHienThi"].ToString();
            acc.MatKhau = dt.Rows[0]["MatKhau"].ToString();
            acc.Loai = int.Parse(dt.Rows[0]["Loai"].ToString());

            DataProvider.DongKetNoi(conn);
            return acc;
        }

        // Xóa account
        public static bool XoaAccount(Account_DTO acc)
        {
            string query = string.Format(@"delete from Account where TenDangNhap=N'{0}'", acc.TenDangNhap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        //them account
        public static bool ThemAccount(Account_DTO acc)
        {
            string query = string.Format(@"insert into Account values('{0}',N'{1}','c4ca4238a0b923820dcc509a6f75849b',{2})", acc.TenDangNhap,acc.TenHienThi, acc.Loai);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // reset pass
        public static bool ResetPass(Account_DTO acc)
        {
            string query = string.Format(@"update Account set MatKhau='c4ca4238a0b923820dcc509a6f75849b' where TenDangNhap='{0}'", acc.TenDangNhap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Sửa account
        public static bool SuaAccount(Account_DTO acc)
        {
            string query = string.Format(@"UPDATE dbo.Account SET TenHienThi=N'{0}', Loai={1} WHERE TenDangNhap='{2}'", acc.TenHienThi, acc.Loai, acc.TenDangNhap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool DoiMK(Account_DTO acc)
        {
            string query = string.Format(@"update Account set MatKhau='{0}' where TenDangNhap='{1}'", acc.MatKhau,acc.TenDangNhap);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

    }
}
