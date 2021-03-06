﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Outliner.Data;
using Outliner.Models;

namespace Outliner.Controllers
{
    public class OutlinesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OutlinesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Outlines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Outlines.ToListAsync());
        }

        // GET: Outlines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outline = await _context.Outlines
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outline == null)
            {
                return NotFound();
            }

            return View(outline);
        }

        // GET: Outlines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Outlines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OutlineName,ID")] Outline outline)
        {
            if (ModelState.IsValid)
            {
                string currentUserName = User.Identity.Name;
                outline.CurrentUserName = currentUserName;
                _context.Add(outline);
                await _context.SaveChangesAsync();
                return Redirect("Characters/Create");
            }
            return View(outline);
        }

        // GET: Outlines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outline = await _context.Outlines.FindAsync(id);
            if (outline == null)
            {
                return NotFound();
            }
            return View(outline);
        }

        // POST: Outlines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OutlineName,ID")] Outline outline)
        {
            if (id != outline.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outline);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutlineExists(outline.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(outline);
        }

        // GET: Outlines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outline = await _context.Outlines
                .FirstOrDefaultAsync(m => m.ID == id);
            if (outline == null)
            {
                return NotFound();
            }

            return View(outline);
        }

        // POST: Outlines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var outline = await _context.Outlines.FindAsync(id);
            _context.Outlines.Remove(outline);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutlineExists(int id)
        {
            return _context.Outlines.Any(e => e.ID == id);
        }
    }
}
