using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace RHPsicotest.WebSite.Utilities
{
    public class Helper
    {
        public static string EncryptMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
                var encryptedString = "";

                for (int i = 0; i < result.Length; i++) encryptedString += result[i].ToString("x2").ToLower();

                password = encryptedString;

                return password;
            }
        }

        public static ClaimsIdentity UserAuthenticate(UserLoginDTO userLoginDTO)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userLoginDTO.IdUser.ToString()),
                new Claim(ClaimTypes.Name, userLoginDTO.Name),
                new Claim(ClaimTypes.Email, userLoginDTO.Email)
            };

            foreach (string role in userLoginDTO.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            foreach (string permission in userLoginDTO.Permissions)
            {
                claims.Add(new Claim("Permission", permission));
            }

            claims.Add(new Claim("Permission", "Dashboard"));

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return identity;
        }

        public static ClaimsIdentity CandidateAuthenticate(CandidateLoginDTO candidateLoginDTO)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, candidateLoginDTO.IdCandidate.ToString()),
                new Claim(ClaimTypes.Name, candidateLoginDTO.Email),
                new Claim(ClaimTypes.Email, candidateLoginDTO.Email),
                new Claim(ClaimTypes.Role, candidateLoginDTO.RoleName),
                new Claim("Position", candidateLoginDTO.PositionName)
            };

            foreach (string permission in candidateLoginDTO.Permissions)
            {
                claims.Add(new Claim("Permission", permission));
            }

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return identity;
        }

        public static bool IsFileTypePDF(IFormFile formFile)
        {
            string type = formFile.ContentType;

            if (type == "application/pdf")
            {
                return true;
            }

            return false;
        }

        public static byte[] FilePDFConvertToArrayOfBytes(IFormFile formFile)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                formFile.CopyTo(stream);

                byte[] filePDFInBytes = stream.ToArray();

                return filePDFInBytes;
            }
        }

        public static byte CalculateAge(DateTime datebirth)
        {
            DateTime currentDate = DateTime.Today;

            byte age = Convert.ToByte(currentDate.Year - datebirth.Year);

            if (datebirth.Month > currentDate.Month) --age;

            return age;
        }


        //public static string SesionGetValue(IPrincipal user, string property)
        //{
        //    var r = ((ClaimsIdentity)user.Identity).FindFirst(property);

        //    return r == null ? "" : r.Value;
        //}

        //public static string SesionGetName(IPrincipal user)
        //{
        //    var r = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.Name);

        //    return r == null ? "" : r.Value;
        //}

        //public static string SesionNameIdentifier(IPrincipal user)
        //{
        //    var r = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.NameIdentifier);

        //    return r == null ? "" : r.Value;
        //}

    }
}
