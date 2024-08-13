using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JappyRetoTecnico.Models
{
    public class UsuarioInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string nombre_completo { get; set; }

        [Required]
        public DateTime fecha_nacimiento { get; set; }
        public int edad {  get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "La contraseña debe de tener una longitud mínima de 8 caracteres")]
        [DataType(DataType.Password)]
        public string contraseña { get; set; }



    }
}
