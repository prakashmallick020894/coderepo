using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AMT_Asset__Mgt_Tool_.Data;
using AMT_Asset__Mgt_Tool_.Models;

namespace AMT_Asset__Mgt_Tool_.Controllers
{
    public class RassetsController : Controller
    {
        private readonly RequestContext _context;

        public RassetsController(RequestContext context)
        {
            _context = context;
        }

        // GET: Rassets
        public async Task<IActionResult> Request()
        {
            return View(await _context.Rasset.ToListAsync());
        }

        // GET: Rassets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasset = await _context.Rasset
                .FirstOrDefaultAsync(m => m.id == id);
            if (rasset == null)
            {
                return NotFound();
            }

            return View(rasset);
        }

        // GET: Rassets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rassets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,category,company,model,processor,ram,hdd,ssd,type,p_date")] Rasset rasset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rasset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Request));
            }
            return View(rasset);
        }

        // GET: Rassets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasset = await _context.Rasset.FindAsync(id);
            if (rasset == null)
            {
                return NotFound();
            }
            return View(rasset);
        }

        // POST: Rassets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,category,company,model,processor,ram,hdd,ssd,type,p_date")] Rasset rasset)
        {
            if (id != rasset.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rasset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RassetExists(rasset.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Request));
            }
            return View(rasset);
        }

        // GET: Rassets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rasset = await _context.Rasset
                .FirstOrDefaultAsync(m => m.id == id);
            if (rasset == null)
            {
                return NotFound();
            }

            return View(rasset);
        }

        // POST: Rassets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rasset = await _context.Rasset.FindAsync(id);
            _context.Rasset.Remove(rasset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Request));
        }

        private bool RassetExists(int id)
        {
            return _context.Rasset.Any(e => e.id == id);
        }
    }
}
