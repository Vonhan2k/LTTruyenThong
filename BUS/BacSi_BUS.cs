using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BacSi_BUS
    {
        //lay danh sanh bac si
        public static List<BacSi_DTO> LayDSBacSi()
        {
            return BacSi_DAO.LayDSBacSi();
        }

        //Them bac si
        public static bool ThemBacSi(BacSi_DTO bs)
        {
            return BacSi_DAO.ThemBacSi(bs);
        }

        //Sua bac si
        public static bool SuaBacSi(BacSi_DTO bs)
        {
            return BacSi_DAO.SuaBacSi(bs);
        }

        //Xóa bac si
        public static bool XoaBacSi(BacSi_DTO bs)
        {
            return BacSi_DAO.XoaBacSi(bs);
        }

        //lay id bac si
        public static BacSi_DTO LayIdBacSi(string bs)
        {
            return BacSi_DAO.LayIdBacSi(bs);
        }

        public static List<BacSi_DTO> LayBacSi(string ten)
        {
            return BacSi_DAO.LayBacSi(ten);
        }
    }
}
