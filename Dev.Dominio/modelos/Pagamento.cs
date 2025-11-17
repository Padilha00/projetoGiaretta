using Dev.Dominio.modelos.Enums;

namespace Dev.Dominio.modelos
{
    public class Pagamento : Base
    {
        public required FormaPagamentoEnum FormaPagamento { get; set; }
        public required string StatusPagamento { get; set; }
        public required string DataPagamento { get; set; }
        
    }

}
