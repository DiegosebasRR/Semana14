using System;
using Microsoft.EntityFrameworkCore;

namespace semana14
{
	public class AppDbContext : DbContext
	{
		string DbPath = string.Empty;

		public DbSet<Product> Product { get; set; }

		public AppDbContext(string dbPath) {
			this.DbPath = dbPath;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}

