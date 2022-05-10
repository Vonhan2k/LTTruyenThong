using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class SaoLuu_PhucHoi_BUS
    {
        public static bool SaoLuu(string link)
        {
            return SaoLuu_PhucHoi_DAO.SaoLuu(link);
        }

        public static bool PhucHoi(string path, string database, string severname, string user, string password)
        {
            return SaoLuu_PhucHoi_DAO.PhucHoi(path, database, severname, user, password);
        }
    }
}
