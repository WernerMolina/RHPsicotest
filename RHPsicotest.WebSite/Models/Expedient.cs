using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Expedient")]
    public class Expedient
    {
        [Key]
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

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        public string Email { get; set; }

        [Display(Name = "Teléfono Movil")]
        [Required(ErrorMessage = "Requerido")]
        public string MovilePhoneNumber { get; set; }

        [Display(Name = "Teléfono Fijo")]
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

        [Display(Name = "Archivo CV")]
        [Required(ErrorMessage = "Requerido")]
        public byte[] CurriculumVitae { get; set; }

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
