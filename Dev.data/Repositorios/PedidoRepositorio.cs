using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.modelos;
using Microsoft.EntityFrameworkCore;

namespace Dev.data.Repositorios
{
    public class PedidoRepositorio(DataContext _context) : IPedidoRepositorio
    {
        public async Task Adicionar(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
           await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Pedido pedido)
        {
            _context.Pedido.Update(pedido);
           await _context.SaveChangesAsync();
        }

        public async Task<IList<Pedido>> Ler()
        {
           return await _context.Pedido
           .AsNoTracking()
           .ToListAsync();
           
        }

        public async Task<Pedido> LerPorId(int id)
        {
            var Pedido = await _context.Pedido.FirstOrDefaultAsync(i => i.Id == id);
            
           if (Pedido == null)
                throw new Exception("O pedido nao encontrado");

            return Pedido;
        }

        public async Task Remover(int id)
        {
           var Pedido = await _context.Pedido.FindAsync(id);

            if (Pedido != null)
            {
                _context.Pedido.Remove(Pedido);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("O Pedido nao encontrado");
                
            
        }

        
    }
    

}