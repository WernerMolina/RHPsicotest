using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.DTOs
{
    public class PositionDTO
    {
        public int IdPosition { get; set; }

        [Display(Name = "Prueba")]
        public int IdTest { get; set; }

        [Display(Name = "Puesto")]
        public string PositionName { get; set; }

        [Display(Name = "Puesto Superior")]
        public string PositionHigher { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Fecha de Creación")]
        public string CreationDate { get; set; }
    }
}
