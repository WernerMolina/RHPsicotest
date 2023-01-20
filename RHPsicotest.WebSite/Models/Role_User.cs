using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    [Table("Role_User")]
    public class Role_User
    {
        [Key]
        public int IdUser { get; set; }

        [Key]
        public int IdRole { get; set; }

        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Models.Role.Users))]
        public virtual Role Role { get; set; }

        [ForeignKey(nameof(IdUser))]
        [InverseProperty(nameof(Models.User.Roles))]
        public virtual User User { get; set; }
    }
}
