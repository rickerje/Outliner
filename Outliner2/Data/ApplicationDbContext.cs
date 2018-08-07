﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Outliner.Models;

namespace Outliner.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Outline> Outlines { get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
