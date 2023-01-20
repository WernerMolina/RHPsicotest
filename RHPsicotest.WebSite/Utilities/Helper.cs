using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace RHPsicotest.WebSite.Utilities
{
    public class Helper
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

        public static bool IsAdmin(UserDTO user)
        {
            bool allow = false;

            foreach (var role in user.Roles)
            {
                if (role.RoleName == "Super-Admin" || role.RoleName == "Administrador")
                    allow = true;
            }

            return allow;
        }

        public static ClaimsIdentity Authenticate(UserDTO user)
        {

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.IdUser.ToString()),
                new Claim(ClaimTypes.Name, user.Name), 
                new Claim(ClaimTypes.Email, user.Email) 
            };

            //var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

            //identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.IdUser.ToString()));
            //identity.AddClaim(new Claim(ClaimTypes.Name, user.Name));
            //identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));

            foreach (var item in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item.RoleName));
            }

            foreach (var item in user.Permissions)
            {
                claims.Add(new Claim("Permission", item.PermissionName));
            }

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return identity;
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
