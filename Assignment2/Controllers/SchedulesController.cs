using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Schedules
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.schedules = _context.Schedules.ToList();
                mymodel.userschedule = _context.MemberEnrol.Where(x => x.Member == User.Identity.Name).ToList();
                return View(mymodel);
            }
            else
            {
                return Redirect("../Identity/Account/Login");
            }

        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedules/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Day, Time, Coach, Location, Date")] Schedules schedules)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedules);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedules);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Schedules.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            return View(items);
        }

        // POST: Schedules/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Day, Time, Coach, Location, Date")] Schedules schedules)
        {
            if (id != schedules.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedules);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsExists(schedules.Id))
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
            return View(schedules);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedules = await _context.Schedules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedules == null)
            {
                return NotFound();
            }

            return View(schedules);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedules = await _context.Schedules.FindAsync(id);
            _context.Schedules.Remove(schedules);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsExists(int id)
        {
            return _context.Schedules.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Enrol(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Schedules.FirstOrDefaultAsync(m => m.Id == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Enrol")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrolConfirmed(int id)
        {
            var item = await _context.Schedules.FindAsync(id);
            var member = User.Identity.Name;
            _context.MemberEnrol.AddRange(new MemberEnrol()
            {
                ScheduleId = item.Id,
                Member = member

            });

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
