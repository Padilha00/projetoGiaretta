using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.interfaces.Servico;
using Dev.Dominio.modelos;
namespace Dev.Dominio.Servico

{
    public class UsuarioServico (IUsuarioRepositorio _usuarioRepositorio): IUsuario
    {
        public async Task Adicionar(Usuario usuario)
        {
            if (usuario is null)
                throw new Exception("Usuario é null");

            await _usuarioRepositorio.Adicionar(usuario);
                
            //validar se a pessoa esta ok e salvar no banco. 
        }

        public Task Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Usuario>> Ler()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> LerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(int id)
        {
            throw new NotImplementedException();
        }
    }

}