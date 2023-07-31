using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels
{
    public class PositionUpdateVM
    {
        public int IdPosition { get; set; }

        [StringLength(50, ErrorMessage = "El máximo de carácteres es 50")]
        [Display(Name = "Nombre del Puesto")]
        [Required(ErrorMessage = "Requerido")]
        public string PositionName { get; set; }

        [StringLength(50, ErrorMessage = "El máximo de carácteres es 50")]
        [Display(Name = "Puesto Superior")]
        [Required(ErrorMessage = "Requerido")]
        public string PositionHigher { get; set; }

        [StringLength(50, ErrorMessage = "El máximo de carácteres es 50")]
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Requerido")]
        public string Department { get; set; }

        public List<int> TestsId{ get; set; }
    }
}
