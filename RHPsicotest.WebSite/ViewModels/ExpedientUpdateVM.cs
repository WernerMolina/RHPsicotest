using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class ExpedientUpdateVM
    {
        public int IdExpedient { get; set; }

        [Display(Name = "DUI")]
        [Required(ErrorMessage = "Requerido")]
        public string DUI { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Requerido")]
        public string Names { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Requerido")]
        public string Lastnames { get; set; }

        [Display(Name = "Teléfono Móvil")]
        [Required(ErrorMessage = "Requerido")]
        public string MovilePhoneNumber { get; set; }

        [Display(Name = "Teléfono Fijo")]
        [Required(ErrorMessage = "Requerido")]
        public string LandlineNumber { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Requerido")]
        public byte Age { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Requerido")]
        public string Gender { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Requerido")]
        public string CivilStatus { get; set; }

        [Display(Name = "Formación Académica")]
        [Required(ErrorMessage = "Requerido")]
        public string AcademicTraining { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Requerido")]
        public string Certificate { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Requerido")]
        public string Direction { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Requerido")]
        public string Country { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Requerido")]
        public string Department { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Requerido")]
        public string Municipality { get; set; }
    }
}
