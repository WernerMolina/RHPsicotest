using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    [Table("Module")]
    public class Module
    {
        [Key]
        public int IdModule { get; set; }

        public string ModuleName { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

    }
}
