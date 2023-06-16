using System;
using CBank.Models;
using Microsoft.EntityFrameworkCore;

namespace CBank.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
            Database.EnsureCreated();
        }

		public DbSet<Cliente> Clientes { get; set; }
	}
}

