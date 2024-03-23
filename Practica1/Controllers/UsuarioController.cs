using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica1.Models;

namespace Practica1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioContext _context;

        public UsuarioController(UsuarioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idusuario,Nombre,Contrasenia,Genero,Direccion,Pasatiempo,Curso,Conocimiento")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
