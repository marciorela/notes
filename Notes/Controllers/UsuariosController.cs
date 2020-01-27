using Microsoft.AspNetCore.Mvc;
using Notes.Models;
using Notes.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuarioRepository _repoUsuario;

        public UsuariosController(UsuarioRepository repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _repoUsuario.GetAll();
            return View(usuarios);
        }
    }
}
