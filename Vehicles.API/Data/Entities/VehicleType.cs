using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    // Entidad VehicleType (Tabla), lleva la DataNotation
    public class VehicleType
    {
        public int Id { get; set; } //table Autoincrementing

        [Display(Name = "Tipo de vehículo")] 
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo  {0} es obligatorio.")]  // Description obligatoria 
        public string Description { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }  //Un vehiculo tiene una lista de vehiculos
    }
}
