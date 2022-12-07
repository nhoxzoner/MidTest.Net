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
    public class ChiTietTranDauController : Controller
    {
        private readonly QuanLyTranDauDbContext _context;

        public ChiTietTranDauController(QuanLyTranDauDbContext context)
        {
            _context = context;
        }

        // GET: ChiTietTranDau
        public async Task<IActionResult> Index()
        {
            var quanLyTranDauDbContext = _context.ChiTietTranDau.Include(c => c.CauThu).Include(c => c.TranDau);
            return View(await quanLyTranDauDbContext.ToListAsync());
        }

        // GET: ChiTietTranDau/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTranDau = await _context.ChiTietTranDau
                .Include(c => c.CauThu)
                .Include(c => c.TranDau)
                .FirstOrDefaultAsync(m => m.IdTranDau == id);
            if (chiTietTranDau == null)
            {
                return NotFound();
            }

            return View(chiTietTranDau);
        }

        // GET: ChiTietTranDau/Create
        public IActionResult Create()
        {
            ViewData["IdCauThu"] = new SelectList(_context.CauThu, "Id", "TenCauThu");
            ViewData["IdTranDau"] = new SelectList(_context.TranDau.Include(x => x.DoiA).Include(x => x.DoiB), "Id", "TentranDau");
            return View();
        }

        // POST: ChiTietTranDau/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTranDau,IdCauThu,SoBanThang")] ChiTietTranDau chiTietTranDau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietTranDau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCauThu"] = new SelectList(_context.CauThu, "Id", "TenCauThu", chiTietTranDau.IdCauThu);
            ViewData["IdTranDau"] = new SelectList(_context.TranDau.Include(x => x.DoiA).Include(x => x.DoiB), "Id", "TenTranDau", chiTietTranDau.IdTranDau);
            return View(chiTietTranDau);
        }

        // GET: ChiTietTranDau/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTranDau = await _context.ChiTietTranDau.FindAsync(id);
            if (chiTietTranDau == null)
            {
                return NotFound();
            }
            ViewData["IdCauThu"] = new SelectList(_context.CauThu, "Id", "TenCauThu", chiTietTranDau.IdCauThu);
            ViewData["IdTranDau"] = new SelectList(_context.TranDau.Include(x => x.DoiA).Include(x => x.DoiB), "Id", "TenTranDau", chiTietTranDau.IdTranDau);
            return View(chiTietTranDau);
        }

        // POST: ChiTietTranDau/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTranDau,IdCauThu,SoBanThang")] ChiTietTranDau chiTietTranDau)
        {
            if (id != chiTietTranDau.IdTranDau)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietTranDau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietTranDauExists(chiTietTranDau.IdTranDau))
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
            ViewData["IdCauThu"] = new SelectList(_context.CauThu, "Id", "TenCauThu", chiTietTranDau.IdCauThu);
            ViewData["IdTranDau"] = new SelectList(_context.TranDau.Include(x => x.DoiA).Include(x => x.DoiB), "Id", "TenTranDau", chiTietTranDau.IdTranDau);
            return View(chiTietTranDau);
        }

        // GET: ChiTietTranDau/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTranDau = await _context.ChiTietTranDau
                .Include(c => c.CauThu)
                .Include(c => c.TranDau)
                .FirstOrDefaultAsync(m => m.IdTranDau == id);
            if (chiTietTranDau == null)
            {
                return NotFound();
            }

            return View(chiTietTranDau);
        }

        // POST: ChiTietTranDau/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietTranDau = await _context.ChiTietTranDau.FindAsync(id);
            _context.ChiTietTranDau.Remove(chiTietTranDau);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietTranDauExists(int id)
        {
            return _context.ChiTietTranDau.Any(e => e.IdTranDau == id);
        }
    }
}
