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
    public class BattleLogsController : Controller
    {
        private readonly RaiderLeagueContext _context;

        public BattleLogsController(RaiderLeagueContext context)
        {
            _context = context;
        }

        // GET: BattleLogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.BattleLog.ToListAsync());
        }

        // GET: BattleLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battleLog = await _context.BattleLog
                .SingleOrDefaultAsync(m => m.ID == id);
            if (battleLog == null)
            {
                return NotFound();
            }

            return View(battleLog);
        }

        // GET: BattleLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BattleLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,klasa,role,log")] BattleLog battleLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(battleLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(battleLog);
        }

        // GET: BattleLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battleLog = await _context.BattleLog.SingleOrDefaultAsync(m => m.ID == id);
            if (battleLog == null)
            {
                return NotFound();
            }
            return View(battleLog);
        }

        // POST: BattleLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,klasa,role,log")] BattleLog battleLog)
        {
            if (id != battleLog.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(battleLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BattleLogExists(battleLog.ID))
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
            return View(battleLog);
        }

        // GET: BattleLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battleLog = await _context.BattleLog
                .SingleOrDefaultAsync(m => m.ID == id);
            if (battleLog == null)
            {
                return NotFound();
            }

            return View(battleLog);
        }

        // POST: BattleLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var battleLog = await _context.BattleLog.SingleOrDefaultAsync(m => m.ID == id);
            _context.BattleLog.Remove(battleLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BattleLogExists(int id)
        {
            return _context.BattleLog.Any(e => e.ID == id);
        }
    }
}
