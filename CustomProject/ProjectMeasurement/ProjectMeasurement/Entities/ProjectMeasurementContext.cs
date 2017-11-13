using Microsoft.EntityFrameworkCore;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Entities
{
    public class ProjectMeasurementContext : DbContext
    {
        public ProjectMeasurementContext(DbContextOptions<ProjectMeasurementContext> options) : base(options)
        {
        }

        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectMember>()
                .HasKey(m => m.MemberId);

            modelBuilder.Entity<ProjectTask>()
                 .HasKey(t => t.TaskId);

            modelBuilder.Entity<Project>()
                .HasKey(p => p.ProjectId);
        }
    }
}
