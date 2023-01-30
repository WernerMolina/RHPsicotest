using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class ExpedientVM
    {
        [Display(Name = "DUI")]
        [Required(ErrorMessage = "Requerido")]
        public string DUI { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Requerido")]
        public string Names { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Requerido")]
        public string Lastnames { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        public string Email { get; set; }

        [Display(Name = "Télefono Movil")]
        [Required(ErrorMessage = "Requerido")]
        public string MovilePhoneNumber { get; set; }

        [Display(Name = "Télefono Fijo")]
        [Required(ErrorMessage = "Requerido")]
        public string LandlineNumber { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Requerido")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "Requerido")]
        public string Gender { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Requerido")]
        public string CivilStatus { get; set; }

        [Display(Name = "Puesto")]
        [Required(ErrorMessage = "Requerido")]
        public string Stall { get; set; }

        [Display(Name = "Formación Académica")]
        [Required(ErrorMessage = "Requerido")]
        public string AcademicTraining { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Requerido")]
        public string Certificate { get; set; }

        [Display(Name = "Curriculum Vitae")]
        [Required(ErrorMessage = "Requerido")]
        public IFormFile CurriculumVitae { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Requerido")]
        public string Country { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Requerido")]
        public string Department { get; set; }

        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "Requerido")]
        public string Municipality { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Requerido")]
        public string Direction { get; set; }

    }
}
