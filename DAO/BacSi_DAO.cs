using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BacSi_DAO
    {
        static SqlConnection conn;

        //lay danh sach tat ca bac si
        public static List<BacSi_DTO> LayDSBacSi()
        {
            string query = "select * from BacSi";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BacSi_DTO> lstBacSi = new List<BacSi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BacSi_DTO bs = new BacSi_DTO();
                bs.IdBacSi = int.Parse(dt.Rows[i]["IdBacSi"].ToString());
                bs.MaBacSi = dt.Rows[i]["MaBacSi"].ToString();
                bs.HoLot = dt.Rows[i]["HoLot"].ToString();
                bs.TenBS = dt.Rows[i]["TenBS"].ToString();
                bs.GioiTinh= dt.Rows[i]["GioiTinh"].ToString();
                bs.NgaySinh= DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                bs.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                bs.SDT = dt.Rows[i]["SDT"].ToString();
                bs.Email = dt.Rows[i]["Email"].ToString();
                bs.HeSoLuong = float.Parse(dt.Rows[i]["HeSoLuong"].ToString());
                lstBacSi.Add(bs);
            }
            DataProvider.DongKetNoi(conn);
            return lstBacSi;
        }

        //Them bac si
        public static bool ThemBacSi(BacSi_DTO bs)
        {
            string query = string.Format(@"insert into BacSi values(N'{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}',{7})", bs.HoLot, bs.TenBS, bs.GioiTinh, bs.NgaySinh.ToString("yyyy/MM/dd"), bs.DiaChi, bs.SDT, bs.Email, bs.HeSoLuong);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Sua bac si
        public static bool SuaBacSi(BacSi_DTO bs)
        {
            string query = string.Format(@"update BacSi set HoLot=N'{0}',TenBS=N'{1}',GioiTinh=N'{2}',NgaySinh='{3}',DiaChi=N'{4}',SDT='{5}',Email='{6}',HeSoLuong={7} where MaBacSi='{8}'",bs.HoLot,bs.TenBS,bs.GioiTinh,bs.NgaySinh.ToString("yyyy/MM/dd"),bs.DiaChi,bs.SDT,bs.Email,bs.HeSoLuong,bs.MaBacSi);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Xóa bac si
        public static bool XoaBacSi(BacSi_DTO bs)
        {
            string query = string.Format(@"delete from BacSi where MaBacSi=N'{0}'", bs.MaBacSi);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        //lay id bac si
        public static BacSi_DTO LayIdBacSi(string id)
        {
            string query = string.Format(@"SELECT IdBacSi FROM dbo.BacSi WHERE HoLot + ' ' + TenBS = N'{0}'", id);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            BacSi_DTO bs = new BacSi_DTO();
            bs.IdBacSi =int.Parse( dt.Rows[0]["IdBacSi"].ToString());

            DataProvider.DongKetNoi(conn);
            return bs;
        }
        public static List<BacSi_DTO> LayBacSi(string ten)
        {
            string query = string.Format(@"select * from BacSi where HoLot+' '+TenBS like N'%{0}%'", ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BacSi_DTO> lstBacSi = new List<BacSi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BacSi_DTO bs = new BacSi_DTO();
                bs.IdBacSi = int.Parse(dt.Rows[i]["IdBacSi"].ToString());
                bs.MaBacSi = dt.Rows[i]["MaBacSi"].ToString();
                bs.HoLot = dt.Rows[i]["HoLot"].ToString();
                bs.TenBS = dt.Rows[i]["TenBS"].ToString();
                bs.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                bs.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                bs.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                bs.SDT = dt.Rows[i]["SDT"].ToString();
                bs.Email = dt.Rows[i]["Email"].ToString();
                bs.HeSoLuong = float.Parse(dt.Rows[i]["HeSoLuong"].ToString());
                lstBacSi.Add(bs);
            }
            DataProvider.DongKetNoi(conn);
            return lstBacSi;
        }

    }
}
