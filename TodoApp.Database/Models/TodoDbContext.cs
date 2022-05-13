using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Database.Model
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<ListGroup> ListGroups { get; set; }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<Task> Tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(b => b.Completed)
                .HasDefaultValue(false);
        }
    }
}
