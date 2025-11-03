using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task Adicionar(Usuario usuario);
        Task<IList<Usuario>> Ler();
        Task Atualizar(Usuario usuario);
        Task Remover(int id);
        Task<Usuario> LerPorId(int id);
    }
}