namespace Dev.Dominio.modelos
{
    public class Pedido : Base
    {

        public int idUsuario { get; set; }
        public int idJogo { get; set; }
        public int Quantidade { get; set; }
        public required string ValorLiquido { get; set; }
        public required string ValorUnitario { get; set; }
        public string? Desconto { get; set; }
        public required string ValorBruto { get; set; }
        public required Pagamento Pagamento { get; set; }

    }


}

