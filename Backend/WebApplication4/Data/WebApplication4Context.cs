using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FITONKgrp7Backend.Models;

namespace FITONKgrp7Backend.Data
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<FITONKgrp7Backend.Models.Vaerktoejskasse> Vaerktoejskasse { get; set; }

        public DbSet<FITONKgrp7Backend.Models.Haandvaerker> Haandvaerker { get; set; }

        public DbSet<FITONKgrp7Backend.Models.Vaerktoej> Vaerktoej { get; set; }
    }
}
