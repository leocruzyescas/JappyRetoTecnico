using JappyRetoTecnico.Models.ViewModels;
namespace JappyRetoTecnico.Models.ViewModels
{
    public class UsuarioFormVM
    {
        public UsuarioInfo Usuario { get; set; } = new();
        public Direccion direccion { get; set; } = new();
    }
}
