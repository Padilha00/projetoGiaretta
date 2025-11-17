using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Repositorio
{
    public interface IPagamentoRepositorio
    {
        Task Adicionar(Pagamento pagamento);
        Task<IList<Pagamento>> Ler();
        Task Atualizar(Pagamento pagamento);
        Task Remover(int id);
        Task<Pagamento> LerPorId(int id);
    }
}