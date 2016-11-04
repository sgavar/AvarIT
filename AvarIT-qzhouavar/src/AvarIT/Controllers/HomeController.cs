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
            var c= _context.ComputerCases.ToList();
            ViewData["ComputerCaseCount"]= c.Count;
            var m = _context.Monitors.ToList();
            ViewData["MonitorCount"] = m.Count;
            var p = _context.Printers.ToList();
            ViewData["PrinterCount"] = p.Count;
            var n = _context.NetWorks.ToList();
            ViewData["NetworkCount"] = n.Count;
            var mis = _context.MiscellaneousItems.ToList();
            ViewData["MiscellaneousCount"] = mis.Count;
            var i= _context.Issues.ToList();
            ViewData["IssuesCount"] = i.Count;
         
            var cp = _context.Computers.Select(v => v.Cost).ToArray();
            ViewData["ComputerSum"] = cp.Sum();
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
