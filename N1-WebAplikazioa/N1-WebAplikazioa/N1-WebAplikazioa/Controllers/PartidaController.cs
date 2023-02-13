using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using N1_WebAplikazioa.Data;
using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Controllers {
    public class PartidaController : Controller {
        private readonly ApplicationDbContext _context;


        public PartidaController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Partida
        public async Task<IActionResult> Index() {
            return _context.Partida != null
                ? View(await _context.Partida.ToListAsync())
                : Problem("Entity set 'ApplicationDbContext.Partida'  is null.");
        }

        // GET: Partida/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null || _context.Partida == null) {
                return NotFound();
            }

            var partida = await _context.Partida
                .FirstOrDefaultAsync(m => m.id == id);
            if (partida == null) {
                return NotFound();
            }

            return View(partida);
        }

        // GET: Partida/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Partida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,data,jokoIzena,puntuazioa")] Partida partida) {
            if (ModelState.IsValid) {
                _context.Add(partida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(partida);
        }

        // GET: Partida/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null || _context.Partida == null) {
                return NotFound();
            }

            var partida = await _context.Partida.FindAsync(id);
            if (partida == null) {
                return NotFound();
            }

            return View(partida);
        }

        // POST: Partida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,data,jokoIzena,puntuazioa")] Partida partida) {
            if (id != partida.id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(partida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!PartidaExists(partida.id)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(partida);
        }

        // GET: Partida/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null || _context.Partida == null) {
                return NotFound();
            }

            var partida = await _context.Partida
                .FirstOrDefaultAsync(m => m.id == id);
            if (partida == null) {
                return NotFound();
            }

            return View(partida);
        }

        // POST: Partida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            if (_context.Partida == null) {
                return Problem("Entity set 'ApplicationDbContext.Partida'  is null.");
            }

            var partida = await _context.Partida.FindAsync(id);
            if (partida != null) {
                _context.Partida.Remove(partida);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartidaExists(int id) {
            return (_context.Partida?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}