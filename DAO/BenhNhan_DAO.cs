using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class BenhNhan_DAO
    {
        static SqlConnection conn;

        //Lay ds Benh nhan
        public static List<BenhNhan_DTO> LayDSBenhNhan()
        {
            string query = "select * from BenhNhan";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhNhan_DTO> lstBenhNhan = new List<BenhNhan_DTO>();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                BenhNhan_DTO bn = new BenhNhan_DTO();
                bn.IdBenhNhan = int.Parse(dt.Rows[i]["IdBenhNhan"].ToString());
                bn.MaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();
                bn.HoLot = dt.Rows[i]["HoLot"].ToString();
                bn.TenBN = dt.Rows[i]["TenBN"].ToString();
                bn.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                bn.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                bn.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                bn.LienHe = dt.Rows[i]["LienHe"].ToString();
                bn.Ghichu = dt.Rows[i]["GhiChu"].ToString();
                lstBenhNhan.Add(bn);
            }
            DataProvider.DongKetNoi(conn);
            return lstBenhNhan;
        }

        //Them benh nhan
        public static bool ThemBenhNhan(BenhNhan_DTO bn)
        {
            string query = string.Format(@"insert into BenhNhan values(N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}')", bn.HoLot, bn.TenBN, bn.GioiTinh, bn.NgaySinh.ToString("yyyy/MM/dd"), bn.DiaChi, bn.LienHe, bn.Ghichu);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Sua benh nhan
        public static bool SuaBenhNhan(BenhNhan_DTO bn)
        {
            string query = string.Format(@"update BenhNhan set HoLot=N'{0}',TenBN=N'{1}',GioiTinh=N'{2}',NgaySinh='{3}',DiaChi=N'{4}',LienHe=N'{5}',GhiChu=N'{6}' where MaBenhNhan=N'{7}'", bn.HoLot, bn.TenBN, bn.GioiTinh, bn.NgaySinh.ToString("MM/dd/yyyy"), bn.DiaChi, bn.LienHe, bn.Ghichu, bn.MaBenhNhan);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;

        }

        // Xoa benh nhan
        public static bool XoaBenhNhan(BenhNhan_DTO bn)
        {
            string query = string.Format(@"delete from BenhNhan where MaBenhNhan=N'{0}'", bn.MaBenhNhan);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<BenhNhan_DTO> LayBenhNhan(string ten)
        {
            string query = string.Format(@"select * from BenhNhan where HoLot+' '+TenBN like N'%{0}%'", ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhNhan_DTO> lstBenhNhan = new List<BenhNhan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BenhNhan_DTO bn = new BenhNhan_DTO();
                bn.IdBenhNhan = int.Parse(dt.Rows[i]["IdBenhNhan"].ToString());
                bn.MaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();
                bn.HoLot = dt.Rows[i]["HoLot"].ToString();
                bn.TenBN = dt.Rows[i]["TenBN"].ToString();
                bn.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                bn.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                bn.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                bn.LienHe = dt.Rows[i]["LienHe"].ToString();
                bn.Ghichu = dt.Rows[i]["GhiChu"].ToString();
                lstBenhNhan.Add(bn);
            }
            DataProvider.DongKetNoi(conn);
            return lstBenhNhan; ;
        }
    }
}
