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
    public class ComputerCasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComputerCasesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ComputerCases
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComputerCases.ToListAsync());
        }

        // GET: ComputerCases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }

            return View(computerCase);
        }

        // GET: ComputerCases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComputerCases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AssignedUser,AvarTagNumber,Brand,CPUFrequency,CPUType,Cost,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,WLANMAC,Warranty")] ComputerCase computerCase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computerCase);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(computerCase);
        }

        // GET: ComputerCases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }
            return View(computerCase);
        }

        // POST: ComputerCases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AssignedUser,AvarTagNumber,Brand,CPUFrequency,CPUType,Cost,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,WLANMAC,Warranty")] ComputerCase computerCase)
        {
            if (id != computerCase.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computerCase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputerCaseExists(computerCase.ID))
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
            return View(computerCase);
        }

        // GET: ComputerCases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }

            return View(computerCase);
        }

        // POST: ComputerCases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            _context.ComputerCases.Remove(computerCase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ComputerCaseExists(int id)
        {
            return _context.ComputerCases.Any(e => e.ID == id);
        }
    }
}
