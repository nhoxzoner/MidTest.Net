using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MidTest.Net.Data;

namespace MidTest.Net.Controllers
{
    public class TranDauController : Controller
    {
        private readonly QuanLyTranDauDbContext _context;

        public TranDauController(QuanLyTranDauDbContext context)
        {
            _context = context;
        }

        // GET: TranDau
        public async Task<IActionResult> Index()
        {
            var quanLyTranDauDbContext = _context.TranDau.Include(t => t.DoiA).Include(t => t.DoiB);
            return View(await quanLyTranDauDbContext.ToListAsync());
        }

        // GET: TranDau/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDau = await _context.TranDau
                .Include(t => t.DoiA)
                .Include(t => t.DoiB)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tranDau == null)
            {
                return NotFound();
            }

            return View(tranDau);
        }

        // GET: TranDau/Create
        public IActionResult Create()
        {
            ViewData["DoiBongA"] = new SelectList(_context.DoiBong, "Id", "Id");
            ViewData["DoiBongB"] = new SelectList(_context.DoiBong, "Id", "Id");
            return View();
        }

        // POST: TranDau/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DoiBongA,DoiBongB,SoBanThangA,SoBanThangB,ThoiGian")] TranDau tranDau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tranDau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoiBongA"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongA);
            ViewData["DoiBongB"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongB);
            return View(tranDau);
        }

        // GET: TranDau/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDau = await _context.TranDau.FindAsync(id);
            if (tranDau == null)
            {
                return NotFound();
            }
            ViewData["DoiBongA"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongA);
            ViewData["DoiBongB"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongB);
            return View(tranDau);
        }

        // POST: TranDau/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DoiBongA,DoiBongB,SoBanThangA,SoBanThangB,ThoiGian")] TranDau tranDau)
        {
            if (id != tranDau.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tranDau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranDauExists(tranDau.Id))
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
            ViewData["DoiBongA"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongA);
            ViewData["DoiBongB"] = new SelectList(_context.DoiBong, "Id", "Id", tranDau.DoiBongB);
            return View(tranDau);
        }

        // GET: TranDau/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranDau = await _context.TranDau
                .Include(t => t.DoiA)
                .Include(t => t.DoiB)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tranDau == null)
            {
                return NotFound();
            }

            return View(tranDau);
        }

        // POST: TranDau/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tranDau = await _context.TranDau.FindAsync(id);
            _context.TranDau.Remove(tranDau);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranDauExists(int id)
        {
            return _context.TranDau.Any(e => e.Id == id);
        }
    }
}
