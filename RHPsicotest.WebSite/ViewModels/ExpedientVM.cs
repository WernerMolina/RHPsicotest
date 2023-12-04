using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class ExpedientVM
    {
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
        [Display(Name = "Télefono Movil")]
        [Required(ErrorMessage = "Requerido")]
        public string MovilePhoneNumber { get; set; }

        [StringLength(9, ErrorMessage = "El máximo de carácteres es 9")]
        [Display(Name = "Télefono Fijo")]
        [Required(ErrorMessage = "Requerido")]
        public string LandlineNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Requerido")]
        public DateTime DateOfBirth { get; set; }

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

        [Display(Name = "Curriculum Vitae")]
        [Required(ErrorMessage = "Requerido")]
        public IFormFile CurriculumVitae { get; set; }

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

        [StringLength(100, ErrorMessage = "El máximo de carácteres es 100")]
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Requerido")]
        public string Direction { get; set; }

    }
}
