using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FarmingCattleApp.Data;
using FarmingCattleApp.Models;

namespace FarmingCattleApp.Controllers
{
    public class CattleController : Controller
    {
        private readonly CattleFarmDbContext _context;

        public CattleController(CattleFarmDbContext context)
        {
            _context = context;
        }

        // GET: Cattle
        public async Task<IActionResult> Index()
        {
              return View(await _context.CattleModel.ToListAsync());
        }

        // GET: Cattle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CattleModel == null)
            {
                return NotFound();
            }

            var cattleModel = await _context.CattleModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cattleModel == null)
            {
                return NotFound();
            }

            return View(cattleModel);
        }

        // GET: Cattle/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cattle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateAndTime,Camp,Breed,Bulls,Cows,BullCalf,CowCalf,NewCalf,Missing,Dead,Branded,Dipped,Injected,Feed,FeedPrice,FeedQuantity,Notes")] CattleModel cattleModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cattleModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cattleModel);
        }

        // GET: Cattle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CattleModel == null)
            {
                return NotFound();
            }

            var cattleModel = await _context.CattleModel.FindAsync(id);
            if (cattleModel == null)
            {
                return NotFound();
            }
            return View(cattleModel);
        }

        // POST: Cattle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateAndTime,Camp,Breed,Bulls,Cows,BullCalf,CowCalf,NewCalf,Missing,Dead,Branded,Dipped,Injected,Feed,FeedPrice,FeedQuantity,Notes")] CattleModel cattleModel)
        {
            if (id != cattleModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cattleModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CattleModelExists(cattleModel.Id))
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
            return View(cattleModel);
        }

        // GET: Cattle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CattleModel == null)
            {
                return NotFound();
            }

            var cattleModel = await _context.CattleModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cattleModel == null)
            {
                return NotFound();
            }

            return View(cattleModel);
        }

        // POST: Cattle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CattleModel == null)
            {
                return Problem("Entity set 'CattleFarmDbContext.CattleModel'  is null.");
            }
            var cattleModel = await _context.CattleModel.FindAsync(id);
            if (cattleModel != null)
            {
                _context.CattleModel.Remove(cattleModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CattleModelExists(int id)
        {
          return _context.CattleModel.Any(e => e.Id == id);
        }
    }
}
