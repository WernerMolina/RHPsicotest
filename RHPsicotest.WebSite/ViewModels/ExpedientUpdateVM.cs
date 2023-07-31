using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class ExpedientUpdateVM
    {
        public int IdExpedient { get; set; }

        [StringLength(10, ErrorMessage = "El máximo de carácteres es 10")]
        [Display(Name = "DUI")]
        [Required(ErrorMessage = "Requerido")]
        public string DUI { get; set; }

        [StringLength(25, ErrorMessage = "El máximo de carácteres es 25")]
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Requerido")]
        public string Names { get; set; }

        [StringLength(35, ErrorMessage = "El máximo de carácteres es 35")]
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Requerido")]
        public string Lastnames { get; set; }

        [StringLength(9, ErrorMessage = "El máximo de carácteres es 9")]
        [Display(Name = "Teléfono Móvil")]
        [Required(ErrorMessage = "Requerido")]
        public string MovilePhoneNumber { get; set; }

        [StringLength(9, ErrorMessage = "El máximo de carácteres es 9")]
        [Display(Name = "Teléfono Fijo")]
        [Required(ErrorMessage = "Requerido")]
        public string LandlineNumber { get; set; }

        [Range(15, 100, ErrorMessage = "La edad permitida es de 15 a 100 años")]
        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Requerido")]
        public byte Age { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "Requerido")]
        public string Gender { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Requerido")]
        public string CivilStatus { get; set; }

        [Display(Name = "Formación Académica")]
        [Required(ErrorMessage = "Requerido")]
        public string AcademicTraining { get; set; }

        [StringLength(100, ErrorMessage = "El máximo de carácteres es 100")]
        [Display(Name = "Título Técnico/Universitario")]
        [Required(ErrorMessage = "Requerido")]
        public string Certificate { get; set; }

        [StringLength(100, ErrorMessage = "El máximo de carácteres es 100")]
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Requerido")]
        public string Direction { get; set; }

        [StringLength(20, ErrorMessage = "El máximo de carácteres es 20")]
        [Display(Name = "País")]
        [Required(ErrorMessage = "Requerido")]
        public string Country { get; set; }

        [StringLength(20, ErrorMessage = "El máximo de carácteres es 20")]
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Requerido")]
        public string Department { get; set; }

        [StringLength(20, ErrorMessage = "El máximo de carácteres es 20")]
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Requerido")]
        public string Municipality { get; set; }
    }
}
