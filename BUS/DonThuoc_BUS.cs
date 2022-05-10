using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DonThuoc_BUS
    {
        //lay don thuoc
        public static List<DonThuoc_DTO> LayDonThuoc(int madon)
        {
            return DonThuoc_DAO.LayDonThuoc(madon);
        }

        //Them thuoc
        public static bool ThemThuoc(DonThuoc_DTO d)
        {
            return DonThuoc_DAO.ThemThuoc(d);
        }

        //Sua thuoc
        public static bool SuaThuoc(DonThuoc_DTO d)
        {
            return DonThuoc_DAO.SuaThuoc(d);
        }

        //xoa thuoc
        public static bool XoaThuoc(DonThuoc_DTO d)
        {
            return DonThuoc_DAO.XoaThuoc(d);
        }
    }
}
