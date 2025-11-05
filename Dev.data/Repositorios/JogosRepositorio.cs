using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.modelos;
using Microsoft.EntityFrameworkCore;

namespace Dev.data.Repositorios
{
    public class JogosRepositorio(DataContext _context) : IJogosRepositorio
    {
        public async Task Adicionar(Jogos jogos)
        {
            _context.Jogos.Add(jogos);
           await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Jogos jogos)
        {
            _context.Jogos.Update(jogos);
           await _context.SaveChangesAsync();
        }

        public async Task<IList<Jogos>> Ler()
        {
           return await _context.Jogos
           .AsNoTracking()
           .ToListAsync();
        }

        public async Task<Jogos> LerPorId(int id)
        {
            var jogos = await _context.Jogos.FirstOrDefaultAsync(i => i.Id == id);
            
           if (jogos == null)
                throw new Exception("O jogo nao foi encontrado");

            return jogos;
        }

        public async Task Remover(int id)
        {
           var jogos = await _context.Jogos.FindAsync(id);

            if (jogos != null)
            {
                _context.Jogos.Remove(jogos);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("O jogo nao foi encontrado");
                
            
        }
    }
    

}