using Ai_FitnessAssistant.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Ai_FitnessAssistant.Infrastructure;
public class WorkoutDbContext : DbContext
{
    public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options) : base(options) { }

    public DbSet<WorkoutSession> WorkoutPlans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkoutSession>().ToTable("workout_sessions");
    }
}
