using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.interfaces.Servico;
using Dev.Dominio.modelos;
namespace Dev.Dominio.Servico

{
    public class UsuarioServico (IUsuarioRepositorio _usuarioRepositorio): IUsuarioServico //DI
    {
        public async Task Adicionar(Usuario usuario) //parametro
        {
           if (usuario is null)

                throw new Exception("O usuario nao pode ser nulo");

            await _usuarioRepositorio.Adicionar(usuario);
        }

        public async Task Atualizar(Usuario usuario)
        {
            if (usuario is null)

                throw new Exception("O usuario nao pode ser nulo");

            var usuarioDb = await _usuarioRepositorio.LerPorId(usuario.Id);

            usuarioDb.Nome = usuario.Nome;
            usuarioDb.CPF = usuario.CPF;
            usuarioDb.Email = usuario.Email;
            usuarioDb.Telefone = usuario.Telefone;
            usuarioDb.Senha = usuario.Senha;
            usuarioDb.ConfirmarSenha = usuario.ConfirmarSenha;

            await _usuarioRepositorio.Atualizar(usuarioDb);
        }

        public async Task<IList<Usuario>> Ler()
        {
           return await _usuarioRepositorio.Ler();
        }

        public async Task<Usuario> LerPorId(int id)
        {
           return await _usuarioRepositorio.LerPorId(id);
        }

        public async Task Remover(int id)
        {
            var usuarioDb = await _usuarioRepositorio.LerPorId(id);

            if (usuarioDb is null)

                throw new Exception("O usuario nao pode ser nulo");
                
            await _usuarioRepositorio.Remover(id);
        }
    }

}