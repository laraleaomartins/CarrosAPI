using CarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrosAPI.Repositorio
{
    public class CarroContext : DbContext
    {
        public CarroContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
