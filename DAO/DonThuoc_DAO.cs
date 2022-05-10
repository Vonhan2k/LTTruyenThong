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
    public class DonThuoc_DAO
    {
        static SqlConnection conn;

        public static List<DonThuoc_DTO> LayDonThuoc(int madon)
        {
            string query = string.Format(@"SELECT t.MaThuoc,t.TenThuoc,d.SLSang,d.SLTrua,d.SLChieu,d.SLToi,d.CachDung,(d.SLSang+d.SLTrua+d.SLChieu+d.SLToi)*t.GiaThuoc AS TongTien FROM dbo.PhieuKham p,dbo.DonThuoc d,dbo.Thuoc t WHERE t.MaThuoc=d.MaThuoc AND p.IdPhieuKham=d.IdDonThuoc AND d.IdDonThuoc={0}", madon);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DonThuoc_DTO> lstDonThuoc = new List<DonThuoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonThuoc_DTO d = new DonThuoc_DTO();
                DataRow row = dt.Rows[i];
                d.MaThuoc = (string)row["MaThuoc"];
                d.TenThuoc = (string)row["TenThuoc"];
                d.CachDung = (string)row["CachDung"];
                d.SLSang = (int)row["SLSang"];
                d.SLTrua = (int)row["SLTrua"];
                d.SLChieu = (int)row["SLChieu"];
                d.SLToi = (int)row["SLToi"];
                d.TongTien = (int)row["TongTien"];
                lstDonThuoc.Add(d);
            }
            DataProvider.DongKetNoi(conn);
            return lstDonThuoc;
        }

        //them thuoc
        public static bool ThemThuoc(DonThuoc_DTO d)
        {
            string query = string.Format(@"insert into DonThuoc values({0},'{1}',N'{2}',{3},{4},{5},{6})", d.IdDonThuoc,d.MaThuoc,d.CachDung,d.SLSang,d.SLTrua,d.SLChieu,d.SLToi);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        // Sửa thuoc
        public static bool SuaThuoc(DonThuoc_DTO d)
        {
            string query = string.Format(@"update DonThuoc set CachDung=N'{0}',SLSang={1},SLTrua={2},SLChieu={3},SLToi={4} where IdDonThuoc={5} and MaThuoc='{6}'", d.CachDung,d.SLSang,d.SLTrua,d.SLChieu,d.SLToi,d.IdDonThuoc,d.MaThuoc);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaThuoc(DonThuoc_DTO d)
        {
            string query = string.Format(@"delete from DonThuoc where IdDonThuoc={0} and MaThuoc='{1}'", d.IdDonThuoc,d.MaThuoc);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }
    }
}
