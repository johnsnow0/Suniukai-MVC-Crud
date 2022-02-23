#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Suniukai_MVC_Paskaita.Data;
using Suniukai_MVC_Paskaita.Models;

namespace Suniukai_MVC_Paskaita.Controllers
{
    public class PrekesController : Controller
    {
        private readonly EshopDbContext _context;

        public PrekesController(EshopDbContext context)
        {
            _context = context;
        }

        // GET: Prekes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prekes.ToListAsync());
        }

        // GET: Prekes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preke == null)
            {
                return NotFound();
            }

            return View(preke);
        }

        // GET: Prekes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prekes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pavadinimas,Nuotrauka,Aprasymas,Kaina")] Preke preke)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preke);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preke);
        }

        // GET: Prekes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes.FindAsync(id);
            if (preke == null)
            {
                return NotFound();
            }
            return View(preke);
        }

        // POST: Prekes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Pavadinimas,Nuotrauka,Aprasymas,Kaina")] Preke preke)
        {
            if (id != preke.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preke);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrekeExists(preke.Id))
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
            return View(preke);
        }

        // GET: Prekes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preke = await _context.Prekes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preke == null)
            {
                return NotFound();
            }

            return View(preke);
        }

        // POST: Prekes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var preke = await _context.Prekes.FindAsync(id);
            _context.Prekes.Remove(preke);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrekeExists(string id)
        {
            return _context.Prekes.Any(e => e.Id == id);
        }
    }
}
