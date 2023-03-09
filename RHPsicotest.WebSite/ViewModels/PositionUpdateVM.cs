using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels
{
    public class PositionUpdateVM
    {
        public int IdPosition { get; set; }

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
        [Required(ErrorMessage = "El Departamento es requerido")]
        public string Department { get; set; }
    }
}
