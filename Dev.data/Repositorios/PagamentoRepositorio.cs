using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.modelos;
using Microsoft.EntityFrameworkCore;

namespace Dev.data.Repositorios
{
    public class PagamentoRepositorio(DataContext _context) : IPagamentoRepositorio
    {
        public async Task Adicionar(Pagamento pagamento)
        {
            _context.Pagamento.Add(pagamento);
           await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Pagamento pagamento)
        {
            _context.Pagamento.Update(pagamento);
           await _context.SaveChangesAsync();
        }

        public async Task<IList<Pagamento>> Ler()
        {
           return await _context.Pagamento
           .AsNoTracking()
           .ToListAsync();
        }

        public Task<Pagamento> LerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(int id)
        {
           var pagamento = await _context.Pagamento.FindAsync(id);

            if (pagamento != null)
            {
                _context.Pagamento.Remove(pagamento);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("O pagamento nao encontrado");
                
            
        }
    }
    

}