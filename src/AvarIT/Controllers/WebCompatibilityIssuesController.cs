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
    public class WebCompatibilityIssuesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WebCompatibilityIssuesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: WebCompatibilityIssues
        public async Task<IActionResult> Index()
        {
            return View(await _context.Issues.ToListAsync());
        }

        // GET: WebCompatibilityIssues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webCompatibilityIssues = await _context.Issues.SingleOrDefaultAsync(m => m.ID == id);
            if (webCompatibilityIssues == null)
            {
                return NotFound();
            }

            return View(webCompatibilityIssues);
        }

        // GET: WebCompatibilityIssues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebCompatibilityIssues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ControlName,ControlType,Description,ElementName,ElementType,IssueType,IssueTypeID,PropertyName")] WebCompatibilityIssues webCompatibilityIssues)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webCompatibilityIssues);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(webCompatibilityIssues);
        }

        // GET: WebCompatibilityIssues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webCompatibilityIssues = await _context.Issues.SingleOrDefaultAsync(m => m.ID == id);
            if (webCompatibilityIssues == null)
            {
                return NotFound();
            }
            return View(webCompatibilityIssues);
        }

        // POST: WebCompatibilityIssues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ControlName,ControlType,Description,ElementName,ElementType,IssueType,IssueTypeID,PropertyName")] WebCompatibilityIssues webCompatibilityIssues)
        {
            if (id != webCompatibilityIssues.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webCompatibilityIssues);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebCompatibilityIssuesExists(webCompatibilityIssues.ID))
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
            return View(webCompatibilityIssues);
        }

        // GET: WebCompatibilityIssues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webCompatibilityIssues = await _context.Issues.SingleOrDefaultAsync(m => m.ID == id);
            if (webCompatibilityIssues == null)
            {
                return NotFound();
            }

            return View(webCompatibilityIssues);
        }

        // POST: WebCompatibilityIssues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var webCompatibilityIssues = await _context.Issues.SingleOrDefaultAsync(m => m.ID == id);
            _context.Issues.Remove(webCompatibilityIssues);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WebCompatibilityIssuesExists(int id)
        {
            return _context.Issues.Any(e => e.ID == id);
        }
    }
}
