using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Security.Cryptography;

namespace BUS
{
    public class Account_BUS
    {
        public static List<Account_DTO> LayDSAccount()
        {
            return Account_DAO.LayDSTaiKhoan();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static Account_DTO LayAccount(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhau);
            return Account_DAO.LayAccount(ten, matkhau_mahoa);
        }

        //Xoa account
        public static bool XoaAccount(Account_DTO acc)
        {
            return Account_DAO.XoaAccount(acc);
        }

        //them account
        public static bool ThemAccount(Account_DTO acc)
        {
            return Account_DAO.ThemAccount(acc);
        }

        //reset pass
        public static bool ResetPass(Account_DTO acc)
        {
            return Account_DAO.ResetPass(acc);
        }

        //sua account
        public static bool SuaAccount(Account_DTO acc)
        {
            return Account_DAO.SuaAccount(acc);
        }

        //doi mk
        public static bool DoiMatKhau(Account_DTO acc, string matkhaumoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, matkhaumoi);
            acc.MatKhau = matkhau_mahoa;
            return Account_DAO.DoiMK(acc);
        }
    }  
}
