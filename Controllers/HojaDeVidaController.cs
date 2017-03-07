using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TIA_CV.Controllers
{
    public class HojaDeVidaController : Controller
    {
        public IActionResult Instrucciones()
        {
            return View();
        }

        public IActionResult Paso1()
        {
            return View();
        }

    }
}
