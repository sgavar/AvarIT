using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AvarIT.Data;

namespace AvarIT.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            ViewData["ComputerCaseCount"] = _context.ComputerCases.Count();
            ViewData["MonitorCount"] = _context.Monitors.Count();
            ViewData["PrinterCount"] = _context.Printers.Count();
            ViewData["NetworkCount"] = _context.NetWorks.Count();
            ViewData["MiscellaneousCount"] = _context.MiscellaneousItems.Count();
            ViewData["IssuesCount"] = _context.Issues.Count();
            ViewData["ComputerSum"] = _context.Computers.Select(v => v.Cost).Sum();

            return View();
        }




        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
