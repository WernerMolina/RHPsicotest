
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public virtual IEnumerable<Role_User> Role_Users { get; set; }


    }
}
