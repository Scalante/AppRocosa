using Microsoft.AspNetCore.Mvc;
using Rocosa.Datos;
using Rocosa.Models;

namespace Rocosa.Controllers
{
    public class TipoAplicacionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TipoAplicacionController(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> lista = this._db.TipoAplicacion;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(TipoAplicacion tipoAplicacion)
        {
            this._db.TipoAplicacion.Add(tipoAplicacion);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
