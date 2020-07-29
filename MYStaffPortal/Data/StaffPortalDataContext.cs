﻿using System;
using StaffPortal.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StaffPortal.Models;

namespace StaffPortal.Data
{
    public class StaffPortalDataContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public StaffPortalDataContext(DbContextOptions<StaffPortalDataContext> options) : base(options)
        {
        }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Salary>Salaries { get; set; }




    }
}
