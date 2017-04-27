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
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
			modelBuilder.Entity<Project>().ToTable("Projects");
			modelBuilder.Entity<Task>().ToTable("Tasks");
			modelBuilder.Entity<TimeEntry>().ToTable("TimeEntries");

            modelBuilder.Entity<TimeEntry>().HasOne(e => e.Approver).WithOne();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;database=ef;uid=root;pwd=123456;");
    }

}

