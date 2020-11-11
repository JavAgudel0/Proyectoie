using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyectoie.Web.Data.Entities
{
    public class EmpleadosEntidad
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Cargo { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Departamento { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int ExtensionTelefono { get; set; }


        [Display(Name = "Logo")]
        public string LogoPath { get; set; }


        //Espacio para llave foranea de sucursal
        public ICollection<SucursalEntidad> Sucursales { get; set; }

    }
}
