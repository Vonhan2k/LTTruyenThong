using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        private string tenHienThi;

        public string TenHienThi
        {
            get { return tenHienThi; }
            set { tenHienThi = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private int loai;

        public int Loai
        {
            get { return loai; }
            set { loai = value; }
        }

    }
}
