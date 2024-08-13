using JappyRetoTecnico.Models;
using Microsoft.EntityFrameworkCore;
namespace JappyRetoTecnico.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DbSet <UsuarioInfo> Usuario { get; set; }
        public DbSet <Direccion> Direccion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
    }
}
