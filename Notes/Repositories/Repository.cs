using Notes.Data;
using Notes.Models;
using Notes.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: Entity
    {
        protected NotesContext _ctx;

        public Repository(NotesContext ctx)
        {
            _ctx = ctx;
        }
    }
}
