using System;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    public class Stall
    {
        [Key]
        public int IdStall { get; set; }

        public string StallName { get; set; }

        public string StallHigher { get; set; }

        public string Department { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
