using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BandJam.Data;
using BandJam.Models;

namespace BandJam.Controllers
{
    public class BandMembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BandMembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BandMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.BandMembers.ToListAsync());
        }

        // GET: BandMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bandMember = await _context.BandMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bandMember == null)
            {
                return NotFound();
            }

            return View(bandMember);
        }

        // GET: BandMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BandMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Instrument,BandName")] BandMember bandMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bandMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bandMember);
        }

        // GET: BandMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bandMember = await _context.BandMembers.FindAsync(id);
            if (bandMember == null)
            {
                return NotFound();
            }
            return View(bandMember);
        }

        // POST: BandMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Instrument,BandName")] BandMember bandMember)
        {
            if (id != bandMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bandMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BandMemberExists(bandMember.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bandMember);
        }

        // GET: BandMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bandMember = await _context.BandMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bandMember == null)
            {
                return NotFound();
            }

            return View(bandMember);
        }

        // POST: BandMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bandMember = await _context.BandMembers.FindAsync(id);
            _context.BandMembers.Remove(bandMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BandMemberExists(int id)
        {
            return _context.BandMembers.Any(e => e.Id == id);
        }
    }
}
