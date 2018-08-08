using Microsoft.EntityFrameworkCore;
using BirdsEye.Domain.Models;

namespace BirdsEye.Data
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<InventoryToInventoryStatus> InventoryItemStatus { get; set; }
        public DbSet<InventoryNotes> ItemNote { get; set; }
        public DbSet<InventoryStatus> ItemStatus { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobToUser> JobUser { get; set; }
        public DbSet<JobNotes> WorkNote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryToInventoryStatus>().HasKey(i => new { i.InventoryId , i.ItemStatusId });
            modelBuilder.Entity<JobToUser>().HasKey(j => new { j.JobId, j.UserId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=.;Database=BirdsEyeDB;Trusted_Connection=True;");
        }
    }
}
