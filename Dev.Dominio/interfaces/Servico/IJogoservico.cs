using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Servico
{
    public interface IJogosServico
    {
        Task Adicionar(Jogos jogos);
        Task<IList<Jogos>> Ler();
        Task Atualizar(Jogos jogos);
        Task Remover(int id);
        Task<Jogos> LerPorId(int id);
    }
}