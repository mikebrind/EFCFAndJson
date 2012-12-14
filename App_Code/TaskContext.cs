using System.Data.Entity;

/// <summary>
/// Provides data access for entities
/// </summary>
public class TaskContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }
    public DbSet<TaskType> TaskTypes { get; set; }
}
