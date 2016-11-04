using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvarIT.Data;
using AvarIT.Models.ITInventoryModels;
using AvarIT.Models.ErrorData.attributes;

namespace AvarIT.Controllers
{
    public class ComputerCasesController : Controller
    {
        private readonly ApplicationDbContext _context;


        public ComputerCasesController(ApplicationDbContext context)
        {

            _context = context;



            //tempEmpList = await genreQuery.Distinct().ToListAsyn();
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


        [ImportModelState]
        // GET: ComputerCases/Create
        public IActionResult Create()
        { // Use LINQ to get list of genres.

            var usersList = this._context.ComputerCases.Select(x => x.User).Distinct();

            ViewBag.usersList = usersList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });

            var brandsList = this._context.ComputerCases.Select(x => x.Brand).Distinct();

            ViewBag.brandsList = brandsList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });
            var OEMOSList = this._context.ComputerCases.Select(x => x.OEMOperatingSystem).Distinct();
            ViewBag.OEMOSList = OEMOSList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });

            var UpOSList = this._context.ComputerCases.Select(x => x.UpgradedTo).Distinct();
            ViewBag.UpOSList = UpOSList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });

            return View();
        }

        // POST: ComputerCases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ExportModelState]
        public async Task<IActionResult> Create([Bind("ID,AvarTagNumber,Brand,CPUFrequency,CPUType,Cost,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,User,WLANMAC,Warranty")] ComputerCase computerCase)
        {

            if (ModelState.IsValid)
            {
                _context.Add(computerCase);
                await _context.SaveChangesAsync();
                return Redirect("~/ComputerCases/Create?#page");
            }
            return Redirect("~/ComputerCases/Create?#page");
        }

        [ImportModelState]
        // GET: ComputerCases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var usersList = this._context.ComputerCases.Select(x => x.User).Distinct();

            ViewBag.usersList = usersList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });

            var brandsList = this._context.ComputerCases.Select(x => x.Brand).Distinct();

            ViewBag.brandsList = brandsList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });
            var OEMOSList = this._context.ComputerCases.Select(x => x.OEMOperatingSystem).Distinct();
            ViewBag.OEMOSList = OEMOSList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });

            var UpOSList = this._context.ComputerCases.Select(x => x.UpgradedTo).Distinct();
            ViewBag.UpOSList = UpOSList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });
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
        [ExportModelState]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AvarTagNumber,Brand,CPUFrequency,CPUType,Cost,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,User,WLANMAC,Warranty")] ComputerCase computerCase)
        {
            if (id != computerCase.ID)
            {
                return NotFound();
            }
            var usersList = this._context.ComputerCases.Select(x => x.User).Distinct();

            ViewBag.usersList = usersList.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.ToString()
                                  });
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
                return Redirect("~/ComputerCases/Index?#page");
            }
            return Redirect("~/ComputerCases/Edit/" + computerCase.ID + "?#page");
        }

        // GET: ComputerCases/Delete/5
        [ImportModelState]
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
        [ExportModelState]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            _context.ComputerCases.Remove(computerCase);
            await _context.SaveChangesAsync();
            return Redirect("~/ComputerCases/Index?#page");
        }

        private bool ComputerCaseExists(int id)
        {
            return _context.ComputerCases.Any(e => e.ID == id);
        }

    }
}
