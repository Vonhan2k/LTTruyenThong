using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuKham_DTO
    {
        private int idPhieuKham;

        public int IdPhieuKham
        {
            get { return idPhieuKham; }
            set { idPhieuKham = value; }
        }

        private string maPhieuKham;

        public string MaPhieuKham
        {
            get { return maPhieuKham; }
            set { maPhieuKham = value; }
        }

        private DateTime ngayKham;

        public DateTime NgayKham
        {
            get { return ngayKham; }
            set { ngayKham = value; }
        }

        private int idBenhNhan;

        public int IdBenhNhan
        {
            get { return idBenhNhan; }
            set { idBenhNhan = value; }
        }

        private string benhNhan;

        public string BenhNhan
        {
            get { return benhNhan; }
            set { benhNhan = value; }
        }

        private int idBacSi;

        public int IdBacSi
        {
            get { return idBacSi; }
            set { idBacSi = value; }
        }

        private string bacSi;

        public string BacSi
        {
            get { return bacSi; }
            set { bacSi = value; }
        }

        private string trieuChung;

        public string TrieuChung
        {
            get { return trieuChung; }
            set { trieuChung = value; }
        }

        private string chuanDoan;

        public string ChuanDoan
        {
            get { return chuanDoan; }
            set { chuanDoan = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        private int thanhTien;

        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
