using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Thuoc_BUS
    {
        public static List<Thuoc_DTO> LayDSThuoc()
        {
            return Thuoc_DAO.LayDSThuoc();
        }

        //them thuoc
        public static bool ThemThuoc(Thuoc_DTO th)
        {
            return Thuoc_DAO.ThemThuoc(th);
        }

        //Sua thuoc
        public static bool SuaThuoc(Thuoc_DTO th)
        {
            return Thuoc_DAO.SuaThuoc(th);
        }

        //Xoa thuoc
        public static bool XoaThuoc(Thuoc_DTO th)
        {
            return Thuoc_DAO.XoaThuoc(th);
        }

        //lay 1 thuoc
        public static List<Thuoc_DTO> LayThuoc(string tenthuoc)
        {
            return Thuoc_DAO.LayThuoc(tenthuoc);
        }

        public static Thuoc_DTO LayTenThuoc(string tenthuoc)
        {
            return Thuoc_DAO.LayTenThuoc(tenthuoc);
        }
    }
}
