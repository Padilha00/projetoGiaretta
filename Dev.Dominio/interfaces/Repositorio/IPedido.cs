using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Repositorio
{
    public interface IPedidoRepositorio
    {
        Task Adicionar(Pedido pedido);
        Task<IList<Pedido>> Ler();
        Task Atualizar(Pedido pedido);
        Task Remover(int id);
        Task<Pedido> LerPorId(int id);
    }
}