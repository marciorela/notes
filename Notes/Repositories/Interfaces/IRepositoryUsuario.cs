using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Repositories.Interfaces
{
    public interface IRepositoryUsuario: IRepository<Usuario>
    {
        Task<Usuario> GetById(int id);

        Task<IEnumerable<Usuario>> GetAll();
    }
}
