using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyectoie.Web.Data.Entities
{
    public class SucursalEntidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }


        [MaxLength(3, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres."), MinLength(3, ErrorMessage = "El campo {0} debe tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Prefijo { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Ciudad { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Telefono { get; set; }
    }
}
