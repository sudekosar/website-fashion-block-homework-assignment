using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ModaController : Controller
    {
        public IActionResult Moda()
        {
            return View(Veri.Getir());
        }
        public IActionResult Culture()
        {
            return View(Veri.Getir());
        }
        public IActionResult Beauty()
        {
            return View(Veri.Getir());
        }
        public IActionResult Life()
        {
            return View(Veri.Getir());
        }
    }
}
