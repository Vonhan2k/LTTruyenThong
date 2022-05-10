using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc_DTO
    {
        private string maThuoc;

        public string MaThuoc
        {
            get { return maThuoc; }
            set { maThuoc = value; }
        }

        private string tenThuoc;

        public string TenThuoc
        {
            get { return tenThuoc; }
            set { tenThuoc = value; }
        }

        private string donVi;

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private DateTime nSX;

        public DateTime NSX
        {
            get { return nSX; }
            set { nSX = value; }
        }

        private DateTime hSD;

        public DateTime HSD
        {
            get { return hSD; }
            set { hSD = value; }
        }

        private int giaThuoc;

        public int GiaThuoc
        {
            get { return giaThuoc; }
            set { giaThuoc = value; }
        }
    }
}
