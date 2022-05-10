using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BenhNhan_BUS
    {
        //lay ds benh nhan
        public static List<BenhNhan_DTO> LayDSBenhNhan()
        {
            return BenhNhan_DAO.LayDSBenhNhan();
        }

        //Them benh nahn
        public static bool ThemBenhNhan(BenhNhan_DTO bn)
        {
            return BenhNhan_DAO.ThemBenhNhan(bn);
        }

        //Sửa benh nhan
        public static bool SuaBenhNhan(BenhNhan_DTO bn)
        {
            return BenhNhan_DAO.SuaBenhNhan(bn);
        }

        //Xoa benh nhan
        public static bool XoaBenhNhan(BenhNhan_DTO bn)
        {
            return BenhNhan_DAO.XoaBenhNhan(bn);
        }

        public static List<BenhNhan_DTO> LayBenhNhan(string ten)
        {
            return BenhNhan_DAO.LayBenhNhan(ten);
        }
    }
}
