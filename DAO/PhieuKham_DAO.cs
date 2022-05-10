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
    public class PhieuKham_DAO
    {
        static SqlConnection conn;

        //Lay ds phieu kham
        public static List<PhieuKham_DTO> LayDSPhieuKham()
        {
            string query = "SELECT ph.IdPhieuKham, ph.MaPhieuKham, ph.NgayKham, ph.IdBenhNhan, bn.HoLot+' '+bn.TenBN AS BenhNhan, ph.IdBacSi, bs.HoLot+' '+bs.TenBS AS BacSi,ph.TrieuChung,ph.ChuanDoan,ph.GhiChu, ph.ThanhTien FROM dbo.BenhNhan bn, dbo.BacSi bs,dbo.PhieuKham ph WHERE ph.IdBenhNhan = bn.IdBenhNhan AND ph.IdBacSi = bs.IdBacSi";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuKham_DTO> lstPhieuKham = new List<PhieuKham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuKham_DTO ph = new PhieuKham_DTO();
                ph.IdPhieuKham = int.Parse(dt.Rows[i]["IdPhieuKham"].ToString());
                ph.MaPhieuKham = dt.Rows[i]["MaPhieuKham"].ToString();
                ph.NgayKham = DateTime.Parse(dt.Rows[i]["NgayKham"].ToString());
                ph.IdBenhNhan = int.Parse(dt.Rows[i]["IdBenhNhan"].ToString());
                ph.BenhNhan= dt.Rows[i]["BenhNhan"].ToString();
                ph.IdBacSi = int.Parse(dt.Rows[i]["IdBacSi"].ToString());
                ph.BacSi = dt.Rows[i]["BacSi"].ToString();
                ph.TrieuChung = dt.Rows[i]["TrieuChung"].ToString();
                ph.ChuanDoan = dt.Rows[i]["ChuanDoan"].ToString();
                ph.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                ph.ThanhTien = int.Parse(dt.Rows[i]["ThanhTien"].ToString());
                lstPhieuKham.Add(ph);
            }
            DataProvider.DongKetNoi(conn);
            return lstPhieuKham;
        }

        //Them phieu
        public static bool ThemPhieuKham(PhieuKham_DTO ph)
        {
            string query = string.Format(@"insert into PhieuKham values({0},'{1}',N'{2}',N'{3}',{4},N'{5}',{6})", ph.IdBenhNhan, ph.NgayKham.ToString("MM/dd/yyyy HH:mm:ss"), ph.TrieuChung, ph.ChuanDoan, ph.IdBacSi,ph.GhiChu,ph.ThanhTien);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // xoa phieu
        public static bool XoaPhieuKham(PhieuKham_DTO ph)
        {
            string query = string.Format(@"delete from PhieuKham where MaPhieuKham=N'{0}'", ph.MaPhieuKham);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        //Cong tien
        public static bool CongTien(PhieuKham_DTO ph)
        {
            string query = string.Format(@"UPDATE dbo.PhieuKham SET ThanhTien+={0} WHERE IdPhieuKham={1}",ph.ThanhTien,ph.IdPhieuKham);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static List<PhieuKham_DTO> LayBenhNhan(string ten)
        {
            string query = string.Format(@"SELECT p.*,bn.HoLot+' '+bn.TenBN AS BenhNhan, bs.HoLot+' '+bs.TenBS AS BacSi FROM dbo.PhieuKham p, dbo.BenhNhan bn, dbo.BacSi bs WHERE p.IdBenhNhan=bn.IdBenhNhan AND p.IdBacSi=bs.IdBacSi and bn.HoLot+' '+bn.TenBN=N'{0}'", ten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuKham_DTO> lstPhieu = new List<PhieuKham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuKham_DTO ph = new PhieuKham_DTO();
                ph.IdPhieuKham = int.Parse(dt.Rows[i]["IdPhieuKham"].ToString());
                ph.MaPhieuKham = dt.Rows[i]["MaPhieuKham"].ToString();
                ph.NgayKham = DateTime.Parse(dt.Rows[i]["NgayKham"].ToString());
                ph.IdBenhNhan = int.Parse(dt.Rows[i]["IdBenhNhan"].ToString());
                ph.BenhNhan = dt.Rows[i]["BenhNhan"].ToString();
                ph.IdBacSi = int.Parse(dt.Rows[i]["IdBacSi"].ToString());
                ph.BacSi = dt.Rows[i]["BacSi"].ToString();
                ph.TrieuChung = dt.Rows[i]["TrieuChung"].ToString();
                ph.ChuanDoan = dt.Rows[i]["ChuanDoan"].ToString();
                ph.GhiChu = dt.Rows[i]["GhiChu"].ToString();
                ph.ThanhTien = int.Parse(dt.Rows[i]["ThanhTien"].ToString());
                lstPhieu.Add(ph);
            }
            DataProvider.DongKetNoi(conn);
            return lstPhieu; ;
        }

    }
}
