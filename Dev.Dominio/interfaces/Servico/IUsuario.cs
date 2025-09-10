using Dev.Dominio.modelos;

namespace Dev.Dominio.interfaces.Servico
{
    public interface IUsuario
    {
        //Adicionar - Pessoa 
        Task Adicionar(Usuario usuario);
        //Ler
        Task<IList<Usuario>> Ler();
        //Atualizar
        Task Atualizar(Usuario usuario);
        //Deletar
        Task Remover(int id);
        //Ler(id)
        Task<Usuario> LerPorId(int id);

    }
}