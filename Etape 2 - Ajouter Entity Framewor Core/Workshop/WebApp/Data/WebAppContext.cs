﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {

        public WebAppContext(DbContextOptions<WebAppContext> options)
                    : base(options)
        {
        }

        public DbSet<Commentaire> Commentaires { get; set; }

    }
}
