using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BandJam.Controllers
{
    public class RservationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}