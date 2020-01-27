using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notes.Data;
using Notes.Models;
using Notes.Repositories.Interfaces;

namespace Notes.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IRepositoryUsuario
    {
        public UsuarioRepository(NotesContext ctx) : base(ctx)
        {
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _ctx.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _ctx.Usuarios.FindAsync(id);
        }
    }
}
