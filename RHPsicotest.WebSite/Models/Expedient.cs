using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Expedient")]
    public class Expedient
    {
        [Key]
        public int IdExpedient { get; set; }

        public int IdCandidate { get; set; }

        public string DUI { get; set; }

        public string Names { get; set; }

        public string Lastnames { get; set; }

        public string Email { get; set; }

        public string MovilePhoneNumber { get; set; }

        public string LandlineNumber { get; set; }

        public string EvaluationDate { get; set; }

        public byte Age { get; set; }

        public string Gender { get; set; }

        public string CivilStatus { get; set; }

        public string Position { get; set; }

        public string AcademicTraining { get; set; }

        public string Certificate { get; set; }

        public byte[] CurriculumVitae { get; set; }

        public string FileName { get; set; }

        public string Direction { get; set; }

        public string Country { get; set; }

        public string Department { get; set; }

        public string Municipality { get; set; }

        [ForeignKey(nameof(IdCandidate))]
        [InverseProperty(nameof(Models.Candidate.Expedient))]
        public virtual Candidate Candidate { get; set; }

        [InverseProperty(nameof(Result.Expedient))]
        public virtual IEnumerable<Result> Results { get; set; }
    }
}
