using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FITONKgrp7Backend.Models;

namespace FITONKgrp7Backend.Data
{
    public class HaandvaerkerContext : DbContext
    {
        public HaandvaerkerContext (DbContextOptions<HaandvaerkerContext> options)
            : base(options)
        {
        }


        public DbSet<FITONKgrp7Backend.Models.Vaerktoejskasse> Vaerktoejskasse { get; set; }

        public DbSet<FITONKgrp7Backend.Models.Haandvaerker> Haandvaerker { get; set; }

        public DbSet<FITONKgrp7Backend.Models.Vaerktoej> Vaerktoej { get; set; }
    }
}
