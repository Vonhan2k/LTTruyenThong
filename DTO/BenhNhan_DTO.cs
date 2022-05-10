using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan_DTO
    {
        private int idBenhNhan;

        public int IdBenhNhan
        {
            get { return idBenhNhan; }
            set { idBenhNhan = value; }
        }

        private string maBenhNhan;

        public string MaBenhNhan
        {
            get { return maBenhNhan; }
            set { maBenhNhan = value; }
        }

        private string hoLot;

        public string HoLot
        {
            get { return hoLot; }
            set { hoLot = value; }
        }

        private string tenBN;

        public string TenBN
        {
            get { return tenBN; }
            set { tenBN = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string lienHe;

        public string LienHe
        {
            get { return lienHe; }
            set { lienHe = value; }
        }

        private string ghichu;

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
