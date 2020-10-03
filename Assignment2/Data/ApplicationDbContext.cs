using System;
using System.Collections.Generic;
using System.Text;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment1.Models.Schedules> Schedules { get; set; }
        public DbSet<Assignment1.Models.MemberEnrol> MemberEnrol { get; set; }
        public DbSet<Assignment1.Models.Coaches> Coaches { get; set; }
    }
}
