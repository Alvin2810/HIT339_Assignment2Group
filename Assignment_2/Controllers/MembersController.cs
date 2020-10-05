using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_2.Data;
using Assignment_2.Viewmodel;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MembersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                var role = (from r in _context.Roles
                            join bb in _context.UserRoles on r.Id equals bb.RoleId
                            join cc in _context.Users on bb.UserId equals cc.Id
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
    }
}
