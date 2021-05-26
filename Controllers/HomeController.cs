using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuscoApp.Models;

namespace BuscoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BuscoContext _context;

        public HomeController(ILogger<HomeController> logger, BuscoContext context)
        {
            _logger = logger;
            _context = context;
        }
        //Lista de Productos
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarProd()
        {   
            var Productos = _context.Productos.ToList();
            return View(Productos);
        }

        //Registro de Productos
        public IActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Producto p){
            if (ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
