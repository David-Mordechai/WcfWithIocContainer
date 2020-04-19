using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataLibrary
{
    public class DataLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        //public DataLibraryDbContext(DbContextOptions<DataLibraryDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebApiDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
