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
    public class DoiBongController : Controller
    {
        private readonly QuanLyTranDauDbContext _context;

        public DoiBongController(QuanLyTranDauDbContext context)
        {
            _context = context;
        }

        // GET: DoiBong
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoiBong.ToListAsync());
        }

        // GET: DoiBong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiBong = await _context.DoiBong
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doiBong == null)
            {
                return NotFound();
            }

            return View(doiBong);
        }

        // GET: DoiBong/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoiBong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaDoi,TenDoi,TenQuocGia,SoCauThu")] DoiBong doiBong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doiBong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doiBong);
        }

        // GET: DoiBong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiBong = await _context.DoiBong.FindAsync(id);
            if (doiBong == null)
            {
                return NotFound();
            }
            return View(doiBong);
        }

        // POST: DoiBong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaDoi,TenDoi,TenQuocGia,SoCauThu")] DoiBong doiBong)
        {
            if (id != doiBong.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doiBong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoiBongExists(doiBong.Id))
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
            return View(doiBong);
        }

        // GET: DoiBong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiBong = await _context.DoiBong
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doiBong == null)
            {
                return NotFound();
            }

            return View(doiBong);
        }

        // POST: DoiBong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doiBong = await _context.DoiBong.FindAsync(id);
            _context.DoiBong.Remove(doiBong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoiBongExists(int id)
        {
            return _context.DoiBong.Any(e => e.Id == id);
        }
    }
}
