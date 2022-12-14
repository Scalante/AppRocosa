using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocosa.Datos;
using Rocosa.Models;
using Rocosa.Models.ViewModels;
using System.Diagnostics;

namespace Rocosa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext db, ILogger<HomeController> logger)
        {
            this._db = db;
            this._logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel(){
                Productos = this._db.Producto.Include(c=> c.Categoria).Include(t=>t.TipoAplicacion),
                Categorias = this._db.Categoria
            };
            return View(homeVM);
        }

        [HttpGet]
        public IActionResult Detalle(int Id)
        {
            DetalleViewModel detalleVM = new DetalleViewModel()
            {
                Producto = this._db.Producto.Include(c => c.Categoria).Include(t => t.TipoAplicacion)
                                            .Where(p => p.Id == Id).FirstOrDefault(),
                ExisteEnCarro = false
            };
            return View(detalleVM);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}