using Dev.Dominio.modelos.Enums;

namespace Dev.Dominio.modelos
{
    public class Pagamento
    {
        public required PagamentoEnum FormaPagamento { get; set; }
        public required string StatusPagamento { get; set; }
        public required string DataPagamento { get; set; }

    }

}
