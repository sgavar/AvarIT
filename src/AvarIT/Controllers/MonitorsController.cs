using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvarIT.Data;
using AvarIT.Models.InventoryModels;

namespace AvarIT.Controllers
{
    public class MonitorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MonitorsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Monitors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Monitors.ToListAsync());
        }

        // GET: Monitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitors.SingleOrDefaultAsync(m => m.ID == id);
            if (monitor == null)
            {
                return NotFound();
            }

            return View(monitor);
        }

        // GET: Monitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AssignedUser,AvarTagNumber,Brand,Cost,DVI,HDMI,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,ScreenSize,ScreenType,SerialNumber,VGA,Warranty")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monitor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(monitor);
        }

        // GET: Monitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitors.SingleOrDefaultAsync(m => m.ID == id);
            if (monitor == null)
            {
                return NotFound();
            }
            return View(monitor);
        }

        // POST: Monitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AssignedUser,AvarTagNumber,Brand,Cost,DVI,HDMI,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,ScreenSize,ScreenType,SerialNumber,VGA,Warranty")] Monitor monitor)
        {
            if (id != monitor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonitorExists(monitor.ID))
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
            return View(monitor);
        }

        // GET: Monitors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monitor = await _context.Monitors.SingleOrDefaultAsync(m => m.ID == id);
            if (monitor == null)
            {
                return NotFound();
            }

            return View(monitor);
        }

        // POST: Monitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monitor = await _context.Monitors.SingleOrDefaultAsync(m => m.ID == id);
            _context.Monitors.Remove(monitor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MonitorExists(int id)
        {
            return _context.Monitors.Any(e => e.ID == id);
        }
    }
}
