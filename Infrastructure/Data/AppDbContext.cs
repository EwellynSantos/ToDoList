using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
                : base(options)
            {
            }

        public DbSet<User> User { get; set; }
        public DbSet<TaskList> TaskList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskList>()
                .Property(t => t.StatusTask)
                .HasConversion<string>();

            modelBuilder.Entity<TaskList>()
                .Property(t => t.Priority)
                .HasConversion<string>();

            modelBuilder.Entity<TaskList>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
