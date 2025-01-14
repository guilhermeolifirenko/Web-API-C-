﻿using ApiPassagem.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPassagem.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Passagem> Passagem { get; set; }
    }
}
