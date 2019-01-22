using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BandJam.Models;
using Microsoft.AspNetCore.Authorization;
using BandJam.Data;

namespace BandJam.Controllers
{
    public class BandsController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public BandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bands = _context.Bands;

            return View(bands);

        }

        public ActionResult Create()
        {
            {

                return View();
            }
        }
        public ActionResult Edit()
        {
            {

                return View();
            }
        }
        public ActionResult Delete()
        {
            {

                return View();
            }
        }
    }
}
