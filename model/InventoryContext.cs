using System;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
    }
}
