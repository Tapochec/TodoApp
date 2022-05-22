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

            #region Начальные данные
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "andrew@example.com", Password = "qwe" }
            );

            modelBuilder.Entity<ListGroup>().HasData(
                new ListGroup { Id = 1, UserId = 1, Name = "Group 1" }
            );

            modelBuilder.Entity<TaskList>().HasData(
                new TaskList { Id = 1, UserId = 1, Name = "List1" },
                new TaskList { Id = 2, UserId = 1, TaskGroupId = 1, Name = "List2" }
            );

            modelBuilder.Entity<Task>().HasData(
                new Task { Id = 1, TaskListId = 1, Name = "Task1", Desc = "Desc1" },
                new Task { Id = 2, TaskListId = 1, Name = "Task2", Desc = "Desc2" },
                new Task { Id = 3, TaskListId = 1, Name = "Task3", Desc = "Desc3" },
                new Task { Id = 4, TaskListId = 2, Name = "Task4", Desc = "Desc4" },
                new Task { Id = 5, TaskListId = 2, Name = "Task5", Desc = "Desc5" }
            );
            #endregion
        }
    }
}
