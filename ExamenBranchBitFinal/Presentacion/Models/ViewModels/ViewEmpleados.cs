using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentacion.Models.ViewModels
{
    public class ViewEmpleados
    {
        public int NumEmp { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [DisplayName("Correo electronico")]
        [EmailAddress]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [DisplayName("Estatus")]
        public string Estatus { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "La {0} es requerida")]
        public DateTime FechaCreacion { get; set; }

    }
}