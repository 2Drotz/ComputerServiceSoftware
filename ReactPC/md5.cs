using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ReactPC
{
    public class md5
    {
        public static string hashPassword(string password){ // передаем строку с паролем для шифрования
            MD5 md5 = MD5.Create(); //объект класса MD5

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
            return sb.ToString();
        }
    }
}
