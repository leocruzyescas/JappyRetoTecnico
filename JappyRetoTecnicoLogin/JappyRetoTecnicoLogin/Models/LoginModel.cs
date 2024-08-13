using JappyRetoTecnicoLogin.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JappyRetoTecnicoLogin.Models
{
    public class LoginModel : BaseBinding
    {
        [Key]
        public int id {  get; set; }    

        public string nombre_completo { get; set; } 

        public DateTime fecha_nacimiento { get; set; }  

        public int edad {  get; set; }
        [Required]

        public string email { get; set; }
        [Required]
        public string contraseña { get; set; }    

        
    }
}
