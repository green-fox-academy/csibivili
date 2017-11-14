using Microsoft.EntityFrameworkCore;
using ProjectMeasurement.Models;

namespace ProjectMeasurement.Entities
{
    public class MeasurementContext : DbContext
    {
        public MeasurementContext(DbContextOptions<MeasurementContext> options) : base(options)
        {
        }

        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectMember>()
                .HasKey(m => m.EmailAddress);

            modelBuilder.Entity<ProjectTask>()
                 .HasKey(t => t.TaskId);

            modelBuilder.Entity<Project>()
                .HasKey(p => p.ProjectName);

            modelBuilder.Entity<Measurement>()
                .HasKey(m => m.MeasurementId);
        }
    }
}
