using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using JappyRetoTecnico.Models;
namespace JappyRetoTecnico.Models
{
    public class Direccion
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey ("UsuarioInfo")]
        public int usuarioId { get; set; }

        [Required]
        public  string direccion { get; set; }

        [Required]
        public string colonia  { get; set; }

        [Required]
        public string ciudad { get; set; }

        [Required]
        public  string pais { get; set; }

        [Required]
        public  string codigoPostal { get; set; }

        public UsuarioInfo Usuario { get; set; }
    }
}
