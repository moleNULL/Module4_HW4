using EFCore_CodeFirst.Configurations;
using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Office> Offices { get; set; } = null!;
        public DbSet<Title> Titles { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<EmployeeProject> EmployeeProjects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
        }
    }
}
