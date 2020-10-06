using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_2.Data;
using Assignment_2.Models;
using Assignment_2.Viewmodel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Controllers
{   

    
    public class CoachesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CoachesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var role = (from r in _context.Roles join bb in _context.UserRoles on r.Id equals bb.RoleId join cc in _context.Users on bb.UserId equals cc.Id
                            select new
                            {
                                id = cc.Id,
                                Fname = cc.Fname,
                                Lname = cc.Lname,
                                Age = cc.Age,
                                Role = r.Name
                            }).ToList();

                var blah = role.Select(p => new CoachViewmodel()

                {
                    Fname = p.Fname,
                    id = p.id,
                    Lname = p.Lname,
                    Age = p.Age,
                    Role = p.Role
                });


                return View(blah);
                
            }
            else
            {
                return Redirect("../Identity/Account/Login");
            }

        }

        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = (from r in _context.Users where r.Id == id select r);
            if (users == null)
            {
                return NotFound();
            }

            return View(users.ToList());
        }


    }
}
