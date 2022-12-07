using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MidTest.Net.Data;
using MidTest.Net.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MidTest.Net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QuanLyTranDauDbContext _context;

        public HomeController(ILogger<HomeController> logger, QuanLyTranDauDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var dsViTri = _context.ViTri.ToList();
            ViewBag["ViTri"] = dsViTri;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
