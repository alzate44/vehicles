using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; } //table Autoincrementing

        [Display(Name = "Procedimiento")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio.")]  // Procedimiento obligatorio
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]  //Dos decimales
        [Required(ErrorMessage = "El campo  {0} es obligatorio.")]  // Precio obligatoria 
        public decimal Price { get; set; }
    }
}
