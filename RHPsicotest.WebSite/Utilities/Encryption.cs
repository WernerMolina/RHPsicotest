using RHPsicotest.WebSite.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace RHPsicotest.WebSite.Utilities
{
    public class Encryption
    {
        public static string EncryptMD5(string password)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
                var encryptedString = "";

                for (int i = 0; i < result.Length; i++) encryptedString += result[i].ToString("x2").ToLower();

                password = encryptedString;

                return password;
            }
        }
    }
}
