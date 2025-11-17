using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dev.Dominio.modelos;

namespace DevData.Mappings
{
    public class JogosMapping : IEntityTypeConfiguration<Jogos>
    {
        public void Configure(EntityTypeBuilder<Jogos> builder)
        {
            //configuração do banco de dados 
            //tem id
            builder.HasKey(x => x.Id);
            //definir colunas
            builder.Property(x => x.Genero)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");
            builder.Property(x => x.Preco)
                .IsRequired()
                .HasColumnType("Double");
            
        }
    }
}