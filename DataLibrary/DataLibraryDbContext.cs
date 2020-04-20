using DataLibrary.Core;
using DomainLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataLibrary
{
    public class DataLibraryDbContext : DbContext
    {
        private readonly IDataBaseConfiguration _dataBaseConfiguration;

        public DataLibraryDbContext(IDataBaseConfiguration dataBaseConfiguration)
        {
            _dataBaseConfiguration = dataBaseConfiguration;
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dataBaseConfiguration.ConnectionString);
        }
    }
}
