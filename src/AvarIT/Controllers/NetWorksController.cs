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
    public class NetWorksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NetWorksController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: NetWorks
        public async Task<IActionResult> Index()
        {
            return View(await _context.NetWorks.ToListAsync());
        }

        // GET: NetWorks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netWork = await _context.NetWorks.SingleOrDefaultAsync(m => m.ID == id);
            if (netWork == null)
            {
                return NotFound();
            }

            return View(netWork);
        }

        // GET: NetWorks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NetWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AccessPoint,AssignedUser,AvarTagNumber,Brand,Cabel,Cost,DeviceType,Firewall,LANMAC,LANPorts,LANSpeed,Managed,MemorySize,ModelNo,ModelSeries,Modem,NameOrSSID,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,Router,SerialNumber,Switch,WLANMAC,Warranty,WirelessType")] NetWork netWork)
        {
            if (ModelState.IsValid)
            {
                _context.Add(netWork);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(netWork);
        }

        // GET: NetWorks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netWork = await _context.NetWorks.SingleOrDefaultAsync(m => m.ID == id);
            if (netWork == null)
            {
                return NotFound();
            }
            return View(netWork);
        }

        // POST: NetWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AccessPoint,AssignedUser,AvarTagNumber,Brand,Cabel,Cost,DeviceType,Firewall,LANMAC,LANPorts,LANSpeed,Managed,MemorySize,ModelNo,ModelSeries,Modem,NameOrSSID,Note,OfficeLocation,OrderNo,PurchaseDate,Retired,Router,SerialNumber,Switch,WLANMAC,Warranty,WirelessType")] NetWork netWork)
        {
            if (id != netWork.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(netWork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NetWorkExists(netWork.ID))
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
            return View(netWork);
        }

        // GET: NetWorks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netWork = await _context.NetWorks.SingleOrDefaultAsync(m => m.ID == id);
            if (netWork == null)
            {
                return NotFound();
            }

            return View(netWork);
        }

        // POST: NetWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var netWork = await _context.NetWorks.SingleOrDefaultAsync(m => m.ID == id);
            _context.NetWorks.Remove(netWork);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool NetWorkExists(int id)
        {
            return _context.NetWorks.Any(e => e.ID == id);
        }
    }
}
