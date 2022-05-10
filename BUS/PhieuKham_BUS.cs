using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuKham_BUS
    {
        //lay ds phieu
        public static List<PhieuKham_DTO> LayDSPhieuKham()
        {
            return PhieuKham_DAO.LayDSPhieuKham();
        }

        //Them phieu
        public static bool ThemPhieuKham(PhieuKham_DTO ph)
        {
            return PhieuKham_DAO.ThemPhieuKham(ph);
        }

        //Xoa phieu
        public static bool XoaPhieuKham(PhieuKham_DTO ph)
        {
            return PhieuKham_DAO.XoaPhieuKham(ph);
        }

        //cong tien
        public static bool CongTien(PhieuKham_DTO ph)
        {
            return PhieuKham_DAO.CongTien(ph);
        }

        public static List<PhieuKham_DTO> LayPhieuKham(string ten)
        {
            return PhieuKham_DAO.LayBenhNhan(ten);
        }
    }
}
