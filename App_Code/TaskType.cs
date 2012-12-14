using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents the expected output of a task 
/// </summary>
public class TaskType
{
    [Required]
    public int TaskTypeId { get; set; }
    [Required, MaxLength(50)]
    public string Activity { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
}
