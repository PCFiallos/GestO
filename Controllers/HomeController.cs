using GestorNoticias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GestorNoticias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Agregar()
        {
            return View();
        }
        public IActionResult _Agregar(Noticia noticia)
        {
            NoticiaRepository.AgregarNoticia(noticia);
            return RedirectToAction("Index", "Noticias");
        }
       
        public IActionResult NoticiaNacionales()
        {
            var noticiasNacionales = NoticiaRepository.ObtenerNoticiasPorCategoria("Nacionales");
            ViewBag.NoticiasNacionales = noticiasNacionales;

            return View();
        }

        public IActionResult NoticiasDeportivas()
        {
            var noticiasDeportivas = NoticiaRepository.ObtenerNoticiasPorCategoria("Deportivas");
            ViewBag.NoticiasDeportivas = noticiasDeportivas;

            return View();
        }
        public IActionResult NoticiasMundo()
        {
            var noticiasDeportivas = NoticiaRepository.ObtenerNoticiasPorCategoria("Mundo");
            ViewBag.NoticiasDeportivas = noticiasDeportivas;

            return View();
        }

        public IActionResult NoticiasSociales()
        {
            var noticiasSociales = NoticiaRepository.ObtenerNoticiasPorCategoria("Sociales");
            ViewBag.NoticiasDeportivas = noticiasSociales;

            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}