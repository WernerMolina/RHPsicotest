using System.Collections.Generic;

namespace RHPsicotest.WebSite.DTOs
{
    public class UserLoginDTO
    {
        public int IdUser { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public List<string> Roles{ get; set; }

        public List<string> Permissions{ get; set; }
    }
}
