using Microsoft.EntityFrameworkCore;

namespace Dev.data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<PessoaFisica> PessoaFisica { get; set; }
    public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
}