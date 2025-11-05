using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.interfaces.Servico;
using Dev.Dominio.modelos;

namespace Dev.Dominio.Servico
{
    public class JogosServico(IJogosRepositorio _jogosRepositorio) : IJogosServico
    {
        public async Task Adicionar(Jogos jogos)
        {
            if (jogos is null)
                throw new Exception("O jogo não pode ser nulo");

            await _jogosRepositorio.Adicionar(jogos);
        }

        public async Task Atualizar(Jogos jogos)
        {
            if (jogos is null)
                throw new Exception("O jogo não pode ser nulo");

            var jogoDb = await _jogosRepositorio.LerPorId(jogos.Id);

            jogoDb.Nome = jogos.Nome;
            jogoDb.Descricao = jogos.Descricao;
            jogoDb.Genero = jogos.Genero;
            jogoDb.Preco = jogos.Preco;

            await _jogosRepositorio.Atualizar(jogoDb);
        }

        public async Task<IList<Jogos>> Ler()
        {
            return await _jogosRepositorio.Ler();
        }

        public async Task<Jogos> LerPorId(int id)
        {
            return await _jogosRepositorio.LerPorId(id);
        }

        public async Task Remover(int id)
        {
            await _jogosRepositorio.Remover(id);
        }
    }
}
