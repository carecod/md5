using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace md5
{
    class SifreleM
    {
        static public string Md5Sifreleme(string metin)
        {

            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            byte[] bte = Encoding.UTF8.GetBytes(metin);
            bte=Md5.ComputeHash(bte);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in bte)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();

        }


    }
}
