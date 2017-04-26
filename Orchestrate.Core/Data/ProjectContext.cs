using System;
using Orchestrate.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Orchestrate.Core.Data
{
    public class ProjectContext: DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
			modelBuilder.Entity<Project>().ToTable("Projects");
			modelBuilder.Entity<TaskModel>().ToTable("Tasks");
			modelBuilder.Entity<TimeEntry>().ToTable("TimeEntries");

            modelBuilder.Entity<TimeEntry>().HasOne(e => e.Approver).WithOne();
		}
    }

}

