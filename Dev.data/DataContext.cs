using Microsoft.EntityFrameworkCore;
using Dev.Dominio.modelos;

namespace Dev.data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Jogos> Jogos { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        

    }
}