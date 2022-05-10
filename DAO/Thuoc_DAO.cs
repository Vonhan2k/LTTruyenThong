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
    public class Thuoc_DAO
    {
        static SqlConnection conn;
        public static List<Thuoc_DTO> LayDSThuoc()
        {
            string query = "select * from Thuoc";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Thuoc_DTO> lstThuoc = new List<Thuoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Thuoc_DTO th = new Thuoc_DTO();
                th.MaThuoc = dt.Rows[i]["MaThuoc"].ToString();
                th.TenThuoc = dt.Rows[i]["TenThuoc"].ToString();
                th.DonVi = dt.Rows[i]["DonVi"].ToString();
                th.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                th.NSX = DateTime.Parse(dt.Rows[i]["NSX"].ToString());
                th.HSD = DateTime.Parse(dt.Rows[i]["HSD"].ToString());
                th.GiaThuoc = int.Parse(dt.Rows[i]["GiaThuoc"].ToString());
                lstThuoc.Add(th);
            }
            DataProvider.DongKetNoi(conn);
            return lstThuoc;
        }

        //them thuoc
        public static bool ThemThuoc(Thuoc_DTO th)
        {
            string query = string.Format(@"insert into Thuoc values('{0}',N'{1}',N'{2}',{3},'{4}','{5}',{6})", th.MaThuoc, th.TenThuoc, th.DonVi, th.SoLuong, th.NSX, th.HSD,th.GiaThuoc);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Sửa thuoc
        public static bool SuaThuoc(Thuoc_DTO th)
        {
            string query = string.Format(@"update Thuoc set TenThuoc=N'{0}',DonVi=N'{1}',SoLuong={2},NSX='{3}',HSD='{4}',GiaThuoc={5} where MaThuoc='{6}'", th.TenThuoc, th.DonVi, th.SoLuong, th.NSX.ToString("MM/dd/yyyy"), th.HSD.ToString("MM/dd/yyyy"), th.GiaThuoc, th.MaThuoc);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Xóa thuoc
        public static bool XoaThuoc(Thuoc_DTO th)
        {
            string query = string.Format(@"delete from Thuoc where MaThuoc=N'{0}'", th.MaThuoc);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        //Lay 1 thuoc
        public static List<Thuoc_DTO> LayThuoc(string tenthuoc)
        {
            string query = string.Format(@"select * from Thuoc where TenThuoc like '%{0}%'", tenthuoc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Thuoc_DTO> lstThuoc = new List<Thuoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Thuoc_DTO th = new Thuoc_DTO();
                th.MaThuoc = dt.Rows[i]["MaThuoc"].ToString();
                th.TenThuoc = dt.Rows[i]["TenThuoc"].ToString();
                th.DonVi = dt.Rows[i]["DonVi"].ToString();
                th.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                th.NSX = DateTime.Parse(dt.Rows[i]["NSX"].ToString());
                th.HSD = DateTime.Parse(dt.Rows[i]["HSD"].ToString());
                th.GiaThuoc = int.Parse(dt.Rows[i]["GiaThuoc"].ToString());
                lstThuoc.Add(th);
            }

            DataProvider.DongKetNoi(conn);
            return lstThuoc;
        }

        public static Thuoc_DTO LayTenThuoc(string tenthuoc)
        {
            string query = string.Format(@"select * from Thuoc where TenThuoc='{0}'", tenthuoc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Thuoc_DTO th = new Thuoc_DTO();
            th.MaThuoc = dt.Rows[0]["MaThuoc"].ToString();
            th.TenThuoc = dt.Rows[0]["TenThuoc"].ToString();
            th.DonVi = dt.Rows[0]["DonVi"].ToString();
            th.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
            th.NSX = DateTime.Parse(dt.Rows[0]["NSX"].ToString());
            th.HSD = DateTime.Parse(dt.Rows[0]["HSD"].ToString());
            th.GiaThuoc = int.Parse(dt.Rows[0]["GiaThuoc"].ToString());

            DataProvider.DongKetNoi(conn);
            return th;
        }
    }
}
