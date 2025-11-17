using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dev.Dominio.modelos;

namespace DevData.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //configuração do banco de dados 
            //tem id
            builder.HasKey(x => x.Id);
            //definir colunas
            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar(20)");
            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(15)");
            builder.Property(x => x.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");
        }
    }
}
