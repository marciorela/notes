using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        
    }
}
