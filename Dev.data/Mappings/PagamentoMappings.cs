using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dev.Dominio.modelos;

namespace DevData.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            //configuração do banco de dados 
            //tem id
            builder.HasKey(x => x.Id);
            //definir colunas
            builder.Property(x => x.FormaPagamento)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(x => x.StatusPagamento)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(x => x.DataPagamento)
                .IsRequired()
                .HasColumnType("DateTime");
        }
    }
}
