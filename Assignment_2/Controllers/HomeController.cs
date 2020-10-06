using System.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment_2.Models;
using Assignment_2.Data;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using Assignment_2.Viewmodel;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<ScheduleViewmodel> CustomerVMlist = new List<ScheduleViewmodel>(); // to hold list of Customer and order details


                var schedulelist = (from bb in _context.MemberEnrol join aa in _context.Schedules on bb.ScheduleId equals aa.Id join cc in _context.Users on aa.Coach equals cc.Email select new { Date = aa.Date, CoachName = cc.Fname, Coach = cc.Id, Time = aa.Time, Location = aa.Location, Day = aa.Day, Member = bb.Member, Id = aa.Id }).ToList();

                //query getting data from database from joining two tables and storing data in customerlist

                foreach (var item in schedulelist)

                {

                    ScheduleViewmodel objcvm = new ScheduleViewmodel(); // ViewModel

                    objcvm.Id = item.Id;

                    objcvm.Date = item.Date;

                    objcvm.Time = item.Time;

                    objcvm.Coach = item.Coach;

                    objcvm.CoachName = item.CoachName;

                    objcvm.Day = item.Day;

                    objcvm.Member = item.Member;

                    objcvm.Location = item.Location;

                    CustomerVMlist.Add(objcvm);

                }

                //Using foreach loop fill data from custmerlist to List<CustomerVM>.

                return View(CustomerVMlist); //List of CustomerVM (ViewModel)
            }
            else
            {
                return Redirect("../Identity/Account/Login");
            }

        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrol = await _context.MemberEnrol
                .FirstOrDefaultAsync(m => m.Member == id);
            if (enrol == null)
            {
                return NotFound();
            }

            return View(enrol);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {

            var enrol = await _context.MemberEnrol.FirstOrDefaultAsync(m => m.Member == id);
            _context.MemberEnrol.Remove(enrol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}