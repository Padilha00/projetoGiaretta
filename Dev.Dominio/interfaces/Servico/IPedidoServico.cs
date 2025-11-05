using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Servico
{
    public interface IPedidoServico
    {
        Task Adicionar(Pedido pedido);
        Task<IList<Pedido>> Ler();
        Task Atualizar(Pedido pedido);
        Task Remover(int id);
        Task<Pedido> LerPorId(int id);
    }
}