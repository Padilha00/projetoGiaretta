using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.modelos;
using Microsoft.EntityFrameworkCore;

namespace Dev.data.Repositorios
{
    public class UsuarioRepositorio(DataContext _context) : IUsuarioRepositorio
    {
        public async Task Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
           await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
           await _context.SaveChangesAsync();
        }

        public async Task<IList<Usuario>> Ler()
        {
           return await _context.Usuarios
           .AsNoTracking()
           .ToListAsync();
        }

        public async Task<Usuario> LerPorId(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(i => i.Id == id);
            
           if (usuario == null)
                throw new Exception("O usuario nao encontrado");

            return usuario;
        }

        public async Task Remover(int id)
        {
           var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
            else
                throw new Exception("O usuario nao encontrado");
                
            
        }
    }
    

}