﻿using Microsoft.EntityFrameworkCore;
namespace Vega;

public class VegaDbContext : DbContext
{
    public VegaDbContext(DbContextOptions<VegaDbContext>options) : base(options) { }

    public DbSet<Make> Makes { get; set; }
}
