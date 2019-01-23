using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BandJam.Models;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using BandJam.Data;

//namespace BandJam.Controllers
//{
//    public class BandsController : Controller
//    {
//        private ApplicationDbContext _context { get; set; }

//        public BandsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            var bands = _context.Bands;

//            return View(bands);

//        }

//        public ActionResult Create()
//        {
            

//                return View();
//            }

//        [HttpPost]
//        public ActionResult Create([Bind(Include = "ID,BandName,Genre,Bandsize,Experience,BandMembers,Bio,Email")] Band band)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Bands.Add(band);
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(band);
//        }

//        // GET: Band/Edit/
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Band band = _context.Bands.Find(id);
//            if (band == null)
//            {
//                return HttpNotFound();
//            }
//            return View(band);
//        }
//        //Post: Band/Edit
//        [HttpPost]
//        public ActionResult Edit([Bind(Include = "ID,BandName,Genre,Bandsize,Experience,BandMembers,Bio,Email")] Band band)

//        {

//            return View();
//        }
    
//        [HttpPost]
//        public IActionResult Delete (int id)
//    {
//        Band band = _context.Bands.Find(id);
//        _context.Bands.Remove(band);
//        _context.SaveChanges();
//        return RedirectToAction("Index");
//    }

//        protected override void Dispose(bool disposing)
//    {
//        if (disposing)
//        {
//            _context.Dispose();
//        }
//        base.Dispose(disposing);
//    }
//}
//}
