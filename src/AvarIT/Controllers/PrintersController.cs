using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvarIT.Data;
using AvarIT.Models.InventoryViewModels;

namespace AvarIT.Controllers
{
    public class PrintersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrintersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Printers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Printers.ToListAsync());
        }

        // GET: Printers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers.SingleOrDefaultAsync(m => m.ID == id);
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // GET: Printers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Printers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AssignedUser,AvarTagNumber,Brand,Color,CopyScan,Cost,Dublix,Fax,LAN,LANMAC,MachineName,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PrinterType,PurchaseDate,Retired,SerialNumber,USB,WLANMAC,Warranty,Wireless")] Printer printer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(printer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(printer);
        }

        // GET: Printers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers.SingleOrDefaultAsync(m => m.ID == id);
            if (printer == null)
            {
                return NotFound();
            }
            return View(printer);
        }

        // POST: Printers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AssignedUser,AvarTagNumber,Brand,Color,CopyScan,Cost,Dublix,Fax,LAN,LANMAC,MachineName,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PrinterType,PurchaseDate,Retired,SerialNumber,USB,WLANMAC,Warranty,Wireless")] Printer printer)
        {
            if (id != printer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(printer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrinterExists(printer.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(printer);
        }

        // GET: Printers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers.SingleOrDefaultAsync(m => m.ID == id);
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // POST: Printers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var printer = await _context.Printers.SingleOrDefaultAsync(m => m.ID == id);
            _context.Printers.Remove(printer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PrinterExists(int id)
        {
            return _context.Printers.Any(e => e.ID == id);
        }
    }
}
