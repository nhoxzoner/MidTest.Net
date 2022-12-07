using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MidTest.Net.Data;

namespace MidTest.Net.Controllers
{
    public class HienThiTop10CauThuController : Controller
    {
        private QuanLyTranDauDbContext _context;

        public HienThiTop10CauThuController(QuanLyTranDauDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _context.TranDau
                .Include(x => x.ChiTietTranDau)
                .ThenInclude(x => x.CauThu)
                .ThenInclude(x => x.DoiBong)
                .Select(x => new
                {
                   
                });

            return View();
        }
    }
}
