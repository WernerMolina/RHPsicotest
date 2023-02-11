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

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Fecha")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        [Display(Name = "Puesto")]
        [ForeignKey(nameof(IdPosition))]
        [InverseProperty(nameof(Models.Position.Candidates))]
        public virtual Position Position { get; set; }

        [Display(Name = "Rol")]
        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Models.Role.Candidate))]
        public virtual Role Role{ get; set; }

        [InverseProperty(nameof(Models.Expedient.Candidate))]
        public virtual Expedient Expedient { get; set; }
    }
}
