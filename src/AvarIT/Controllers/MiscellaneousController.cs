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
    public class MiscellaneousController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MiscellaneousController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Miscellaneous
        public async Task<IActionResult> Index()
        {
            return View(await _context.MiscellaneousItems.ToListAsync());
        }

        // GET: Miscellaneous/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miscellaneous = await _context.MiscellaneousItems.SingleOrDefaultAsync(m => m.ID == id);
            if (miscellaneous == null)
            {
                return NotFound();
            }

            return View(miscellaneous);
        }

        // GET: Miscellaneous/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Miscellaneous/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AssignedUser,AvarTagNumber,Brand,Cost,ItemType,LANMAC,License,MachineName,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,WLANMAC,Warranty")] Miscellaneous miscellaneous)
        {
            if (ModelState.IsValid)
            {
                _context.Add(miscellaneous);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(miscellaneous);
        }

        // GET: Miscellaneous/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miscellaneous = await _context.MiscellaneousItems.SingleOrDefaultAsync(m => m.ID == id);
            if (miscellaneous == null)
            {
                return NotFound();
            }
            return View(miscellaneous);
        }

        // POST: Miscellaneous/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AssignedUser,AvarTagNumber,Brand,Cost,ItemType,LANMAC,License,MachineName,ModelNo,ModelSeries,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,WLANMAC,Warranty")] Miscellaneous miscellaneous)
        {
            if (id != miscellaneous.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(miscellaneous);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MiscellaneousExists(miscellaneous.ID))
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
            return View(miscellaneous);
        }

        // GET: Miscellaneous/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miscellaneous = await _context.MiscellaneousItems.SingleOrDefaultAsync(m => m.ID == id);
            if (miscellaneous == null)
            {
                return NotFound();
            }

            return View(miscellaneous);
        }

        // POST: Miscellaneous/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var miscellaneous = await _context.MiscellaneousItems.SingleOrDefaultAsync(m => m.ID == id);
            _context.MiscellaneousItems.Remove(miscellaneous);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MiscellaneousExists(int id)
        {
            return _context.MiscellaneousItems.Any(e => e.ID == id);
        }
    }
}
