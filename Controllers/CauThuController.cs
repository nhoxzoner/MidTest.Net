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
    public class CauThuController : Controller
    {
        private readonly QuanLyTranDauDbContext _context;

        public CauThuController(QuanLyTranDauDbContext context)
        {
            _context = context;
        }

        // GET: CauThu
        public async Task<IActionResult> Index()
        {
            var quanLyTranDauDbContext = _context.CauThu.Include(c => c.DoiBong).Include(c => c.ViTri);
            return View(await quanLyTranDauDbContext.ToListAsync());
        }

        // GET: CauThu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauThu = await _context.CauThu
                .Include(c => c.DoiBong)
                .Include(c => c.ViTri)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cauThu == null)
            {
                return NotFound();
            }

            return View(cauThu);
        }

        // GET: CauThu/Create
        public IActionResult Create()
        {
            ViewData["IdDoiBong"] = new SelectList(_context.DoiBong, "Id", "TenDoi");
            ViewData["IdViTri"] = new SelectList(_context.ViTri, "Id", "TenViTri");
            return View();
        }

        // POST: CauThu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenCauThu,SoAo,IdViTri,IdDoiBong")] CauThu cauThu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauThu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDoiBong"] = new SelectList(_context.DoiBong, "Id", "TenDoi", cauThu.IdDoiBong);
            ViewData["IdViTri"] = new SelectList(_context.ViTri, "Id", "TenViTri", cauThu.IdViTri);
            return View(cauThu);
        }

        // GET: CauThu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauThu = await _context.CauThu.FindAsync(id);
            if (cauThu == null)
            {
                return NotFound();
            }
            ViewData["IdDoiBong"] = new SelectList(_context.DoiBong, "Id", "TenDoi", cauThu.IdDoiBong);
            ViewData["IdViTri"] = new SelectList(_context.ViTri, "Id", "TenViTri", cauThu.IdViTri);
            return View(cauThu);
        }

        // POST: CauThu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenCauThu,SoAo,IdViTri,IdDoiBong")] CauThu cauThu)
        {
            if (id != cauThu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauThu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauThuExists(cauThu.Id))
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
            ViewData["IdDoiBong"] = new SelectList(_context.DoiBong, "Id", "TenDoi", cauThu.IdDoiBong);
            ViewData["IdViTri"] = new SelectList(_context.ViTri, "Id", "TenViTri", cauThu.IdViTri);
            return View(cauThu);
        }

        // GET: CauThu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauThu = await _context.CauThu
                .Include(c => c.DoiBong)
                .Include(c => c.ViTri)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cauThu == null)
            {
                return NotFound();
            }

            return View(cauThu);
        }

        // POST: CauThu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauThu = await _context.CauThu.FindAsync(id);
            _context.CauThu.Remove(cauThu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauThuExists(int id)
        {
            return _context.CauThu.Any(e => e.Id == id);
        }
    }
}
