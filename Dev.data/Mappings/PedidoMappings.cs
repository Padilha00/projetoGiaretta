using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dev.Dominio.modelos;

namespace DevData.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //configuração do banco de dados 
            //tem id
            builder.HasKey(x => x.Id);
            //definir colunas
            builder.Property(x => x.idUsuario)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(x => x.idJogo)
                .IsRequired()   
                .HasColumnType("int");
            builder.Property(x => x.Quantidade)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(x => x.ValorLiquido)
                .IsRequired()
                .HasColumnType("Double");
            builder.Property(x => x.ValorUnitario)
                .IsRequired()
                .HasColumnType("Double");
            builder.Property(x => x.Desconto)
                .IsRequired()
                .HasColumnType("Double");
            builder.Property(x => x.ValorBruto)
                .IsRequired()
                .HasColumnType("Double");
            builder.Property(x => x.Pagamento)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}