﻿using Desert.Captain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Desert.Captain.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
    {}
    public DbSet<Item> Items { get; set; }  
   }
}