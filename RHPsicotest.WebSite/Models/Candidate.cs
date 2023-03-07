using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace RHPsicotest.WebSite.Models
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key]
        public int IdCandidate { get; set; }

        public int IdRole { get; set; }

        public int IdPosition { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RegistrationDate { get; set; }

        [ForeignKey(nameof(IdPosition))]
        [InverseProperty(nameof(Models.Position.Candidates))]
        public virtual Position Position { get; set; }

        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Models.Role.Candidate))]
        public virtual Role Role{ get; set; }

        [InverseProperty(nameof(Models.Expedient.Candidate))]
        public virtual Expedient Expedient { get; set; }
    }
}
