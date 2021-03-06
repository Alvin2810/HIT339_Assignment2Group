﻿using System;
using System.Collections.Generic;
using System.Text;
using Assignment_2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment_2.Models.Schedules> Schedules { get; set; }
        public DbSet<Assignment_2.Models.MemberEnrol> MemberEnrol { get; set; }
    }
}
