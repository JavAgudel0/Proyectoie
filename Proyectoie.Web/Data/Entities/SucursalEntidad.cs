using System.ComponentModel.DataAnnotations;

namespace Proyectoie.Web.Data.Entities
{
    public class SucursalEntidad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [MaxLength(3, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Prefijo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; }

        public int Telefono { get; set; }
    }
}
