using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudNetCore5.Models
{
    public class Usuario
    {
       [Key]
        public int Id { get; set; }

       
        [Required(ErrorMessage ="El nombre es obligatorio")]
        
        [StringLength(50,ErrorMessage = "El {0}  debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0}  debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0}  debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contrasenia es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0}  debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Contrasenia")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

       
        public int EsAdmin { get; set; }
    }
}
