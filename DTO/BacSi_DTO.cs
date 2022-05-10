using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BacSi_DTO
    {
        private int idBacSi;

        public int IdBacSi
        {
            get { return idBacSi; }
            set { idBacSi = value; }
        }

        private string maBacSi;

        public string MaBacSi
        {
            get { return maBacSi; }
            set { maBacSi = value; }
        }

        private string hoLot;

        public string HoLot
        {
            get { return hoLot; }
            set { hoLot = value; }
        }

        private string tenBS;

        public string TenBS
        {
            get { return tenBS; }
            set { tenBS = value; }
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

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private float heSoLuong;
        public float HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
    }
}
