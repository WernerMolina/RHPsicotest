using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

            foreach (Role role in user.Roles)
            {
                if (role.RoleName == "Super-Admin" || role.RoleName == "Administrador")
                    allow = true;
            }

            return allow;
        }

        public static ClaimsIdentity Authenticate(UserDTO userDTO)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userDTO.IdUser.ToString()),
                new Claim(ClaimTypes.Name, userDTO.Name), 
                new Claim(ClaimTypes.Email, userDTO.Email) 
            };

            foreach (Role role in userDTO.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.RoleName));
            }

            foreach (Permission permission in userDTO.Permissions)
            {
                claims.Add(new Claim("Permission", permission.PermissionName));
            }

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return identity;
        }
        
        public static ClaimsIdentity CandidateAuthenticate(Candidate candidate, List<Permission> permissions)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, candidate.IdCandidate.ToString()),
                new Claim(ClaimTypes.Name, candidate.Username), 
                new Claim(ClaimTypes.Email, candidate.Email),
                new Claim(ClaimTypes.Role, candidate.Role.RoleName),
                new Claim("Position", candidate.Position.PositionName)
            };

            foreach (Permission permission in permissions)
            {
                claims.Add(new Claim("Permission", permission.PermissionName));
            }

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return identity;
        }

        public static bool IsFileTypePDF(IFormFile formFile)
        {
            string type = formFile.ContentType;

            if(type == "application/pdf")
            {
                return true;
            }

            return false;
        }

        public static byte[] FilePDFToBytes(IFormFile formFile)
        {
            using(MemoryStream stream = new MemoryStream())
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


        //private readonly IUserService _userService;

        //public AddRolesClaimsTransformation(IUserService userService)
        //{
        //    _userService = userService;
        //}

        //public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        //{
        //    // Clone current identity
        //    var clone = principal.Clone();
        //    var newIdentity = (ClaimsIdentity)clone.Identity;

        //    // Support AD and local accounts
        //    var nameId = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier ||
        //                                                      c.Type == ClaimTypes.Name);
        //    if (nameId == null)
        //    {
        //        return principal;
        //    }

        //    // Get user from database
        //    var user = await _userService.GetByUserName(nameId.Value);
        //    if (user == null)
        //    {
        //        return principal;
        //    }

        //    // Add role claims to cloned identity
        //    foreach (var role in user.Roles)
        //    {
        //        var claim = new Claim(newIdentity.RoleClaimType, role.Name);
        //        newIdentity.AddClaim(claim);
        //    }

        //    return clone;
        //}
    }
}
