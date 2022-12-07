using Microsoft.AspNetCore.Mvc;
using Rocosa.Datos;
using Rocosa.Models;

namespace Rocosa.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = this._db.Categoria;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria categoria)
        {
            this._db.Categoria.Add(categoria);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
