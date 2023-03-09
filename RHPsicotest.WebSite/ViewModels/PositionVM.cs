using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class PositionVM
    {
        [Display(Name = "Prueba")]
        [Required(ErrorMessage = "La prueba es requerida")]
        public int IdTest { get; set; }

        [Display(Name = "Nombre del Puesto")]
        [Required(ErrorMessage = "El Puesto es requerido")]
        public string PositionName { get; set; }

        [Display(Name = "Puesto Superior")]
        [Required(ErrorMessage = "El Puesto Superior es requerido")]
        public string PositionHigher { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El Departamento es requerid")]
        public string Department { get; set; }
    }
}
