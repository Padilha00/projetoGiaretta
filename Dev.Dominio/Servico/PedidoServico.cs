using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.interfaces.Servico;
using Dev.Dominio.modelos;

namespace Dev.Dominio.Servico
{
    public class PedidoServico(IPedidoRepositorio _pedidoRepositorio) : IPedidoServico 
    {
        public async Task Adicionar(Pedido pedido)
        {
            if (pedido is null)
                throw new Exception("O pedido não pode ser nulo");

            await _pedidoRepositorio.Adicionar(pedido);
        }

        public async Task Atualizar(Pedido pedido)
        {
            if (pedido is null)
                throw new Exception("O pedido não pode ser nulo");

            var pedidoDb = await _pedidoRepositorio.LerPorId(pedido.Id);

            pedidoDb.Nome = pedido.Nome;
            pedidoDb.idUsuario = pedido.idUsuario;
            pedidoDb.idJogo = pedido.idJogo;
            pedidoDb.Quantidade = pedido.Quantidade;
            pedidoDb.ValorLiquido = pedido.ValorLiquido;
            pedidoDb.ValorUnitario = pedido.ValorUnitario;
            pedidoDb.Desconto = pedido.Desconto;
            pedidoDb.ValorBruto = pedido.ValorBruto;
            pedidoDb.Pagamento = pedido.Pagamento;

            await _pedidoRepositorio.Atualizar(pedidoDb);
        }

        public async Task<IList<Pedido>> Ler()
        {
            return await _pedidoRepositorio.Ler();
        }

        public async Task<Pedido> LerPorId(int id)
        {
            return await _pedidoRepositorio.LerPorId(id);
        }

        public async Task Remover(int id)
        {
            await _pedidoRepositorio.Remover(id);
        }
    }
}