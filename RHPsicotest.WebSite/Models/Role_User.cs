using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    [Table("Role_User")]
    public class Role_User
    {
        [Key]
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdRole { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }

    }
}
