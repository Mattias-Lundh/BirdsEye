using Microsoft.EntityFrameworkCore;
using BirdsEye.Domain.Models;

namespace BirdsEye.Data
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=.;Database=BirdsEyeDB;Trusted_Connection=True;");
        }
    }
}
