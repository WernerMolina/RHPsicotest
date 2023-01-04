using RHPsicotest.WebSite.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace RHPsicotest.WebSite.Utilities
{
    public class Encryption
    {
        public static void EncryptMD5(Login userLogin)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(userLogin.Password));
                var encryptedString = "";

                for (int i = 0; i < result.Length; i++) encryptedString += result[i].ToString("x2").ToLower();

                userLogin.Password = encryptedString;
            }
        }
    }
}
