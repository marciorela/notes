using Notes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class Nota : Entity
    {
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
