using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RaiderLeague.Models;

namespace RaiderLeague.Controllers
{
    public class BossesController : Controller
    {
        private readonly RaiderLeagueContext _context;

        public BossesController(RaiderLeagueContext context)
        {
            _context = context;
        }

        // GET: Bosses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boss.ToListAsync());
        }

        // GET: Bosses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boss = await _context.Boss
                .SingleOrDefaultAsync(m => m.ID == id);
            if (boss == null)
            {
                return NotFound();
            }

            return View(boss);
        }

        // GET: Bosses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bosses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,bossName,health,damage")] Boss boss)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boss);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boss);
        }

        // GET: Bosses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boss = await _context.Boss.SingleOrDefaultAsync(m => m.ID == id);
            if (boss == null)
            {
                return NotFound();
            }
            return View(boss);
        }

        // POST: Bosses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,bossName,health,damage")] Boss boss)
        {
            if (id != boss.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boss);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BossExists(boss.ID))
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
            return View(boss);
        }

        // GET: Bosses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boss = await _context.Boss
                .SingleOrDefaultAsync(m => m.ID == id);
            if (boss == null)
            {
                return NotFound();
            }

            return View(boss);
        }

        // POST: Bosses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boss = await _context.Boss.SingleOrDefaultAsync(m => m.ID == id);
            _context.Boss.Remove(boss);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BossExists(int id)
        {
            return _context.Boss.Any(e => e.ID == id);
        }
    }
}
