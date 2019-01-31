﻿using System;
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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace BandJam.Controllers
{
    [BindRequired]
    public class BandsController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public BandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            band.BandMembers = (from bmb in _context.BandMemberBands
                                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                where bmb.BandId == id.Value
                                select bm).ToList();
            {
                var bands = _context.Bands;

                return View(bands);

            }
        }

        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]

        public ActionResult Create([Bind("id, BandName, Genre, BandSize, Experience, BandMembers, Bio, Email")] Band band)
        {
            band.BandMembers = (from bmb in _context.BandMemberBands
                                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                where bmb.BandId == id.Value
                                select bm).ToList();
            if (ModelState.IsValid)
            {
                _context.Add(band);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(band);
        }
        
        public ActionResult Details(int? id)
        {
            Band band = _context.Bands.SingleOrDefault(x => x.Id == id.Value);
            band.BandMembers = (from bmb in _context.BandMemberBands
                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                where bmb.BandId == id.Value
                    select bm).ToList();

                return View(band);
            }
                       

        //[HttpPost]
        //public IActionResult Details([Bind("id, BandName, Genre, Bandsize, Experience, BandMembers, Bio, Email")] Band band)
        //{

        //    return View("Details");
        //}

    // GET: Band/Edit/

    public ActionResult Edit(int? id)
        {
            Band band = _context.Bands.SingleOrDefault(x => x.Id == id.Value);
            band.BandMembers = (from bmb in _context.BandMemberBands
                                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                where bmb.BandId == id.Value
                                select bm).ToList();

            return View(band);
        }
        //Post: Band/Edit
        [HttpPost]
        public ActionResult Edit([Bind("id, BandName, Genre, BandSize, Experience, BandMembers, Bio, Email")] Band band)

        {
            band.BandMembers = (from bmb in _context.BandMemberBands
                                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                where bmb.BandId == id.Value
                                select bm).ToList();
            {
                if (ModelState.IsValid)
                    
                _context.Bands.Update(band);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            {
                band.BandMembers = (from bmb in _context.BandMemberBands
                                    join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                    where bmb.BandId == id.Value
                                    select bm).ToList();
            }
            
            Band band = _context.Bands.SingleOrDefault(x => x.Id == id.Value);

            return View(band);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            band.BandMembers = (from bmb in _context.BandMemberBands
                                join bm in _context.BandMembers on bmb.BandMemberId equals bm.Id
                                where bmb.BandId == id.Value
                                select bm).ToList();

            Band band = _context.Bands.Find(id);
                _context.Remove(band);
                _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
//[Bind(ID,BandName,Genre,Bandsize,Experience,BandMembers,Bio,Email)]
//[Bind(Include = "ID,BandName,Genre,Bandsize,Experience,BandMembers,Bio,Email")] 