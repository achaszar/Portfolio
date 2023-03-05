using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SportsRosterModelsController : Controller
    {
        private readonly PortfolioContext _context;

        public SportsRosterModelsController(PortfolioContext context)
        {
            _context = context;
        }

        // GET: SportsRosterModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.SportsRosterModel.ToListAsync());
        }

        // GET: SportsRosterModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SportsRosterModel == null)
            {
                return NotFound();
            }

            var sportsRosterModel = await _context.SportsRosterModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sportsRosterModel == null)
            {
                return NotFound();
            }

            return View(sportsRosterModel);
        }

        // GET: SportsRosterModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SportsRosterModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Number,Position,Bats,Throws")] SportsRosterModel sportsRosterModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sportsRosterModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sportsRosterModel);
        }

        // GET: SportsRosterModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SportsRosterModel == null)
            {
                return NotFound();
            }

            var sportsRosterModel = await _context.SportsRosterModel.FindAsync(id);
            if (sportsRosterModel == null)
            {
                return NotFound();
            }
            return View(sportsRosterModel);
        }

        // POST: SportsRosterModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Number,Position,Bats,Throws")] SportsRosterModel sportsRosterModel)
        {
            if (id != sportsRosterModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sportsRosterModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportsRosterModelExists(sportsRosterModel.Id))
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
            return View(sportsRosterModel);
        }

        // GET: SportsRosterModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SportsRosterModel == null)
            {
                return NotFound();
            }

            var sportsRosterModel = await _context.SportsRosterModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sportsRosterModel == null)
            {
                return NotFound();
            }

            return View(sportsRosterModel);
        }

        // POST: SportsRosterModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SportsRosterModel == null)
            {
                return Problem("Entity set 'PortfolioContext.SportsRosterModel'  is null.");
            }
            var sportsRosterModel = await _context.SportsRosterModel.FindAsync(id);
            if (sportsRosterModel != null)
            {
                _context.SportsRosterModel.Remove(sportsRosterModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportsRosterModelExists(int id)
        {
          return _context.SportsRosterModel.Any(e => e.Id == id);
        }
    }
}
