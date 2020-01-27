using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Data
{
    public class NotesContext : DbContext
    {
        //private IConfiguration _config;



        public NotesContext(DbContextOptions options) : base(options)
        {

        }

        //public NotesContext(IConfiguration config)
        //{
        //    _config = config;
        //}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_config.GetConnectionString("NotesConn"));
        }
    }
}
