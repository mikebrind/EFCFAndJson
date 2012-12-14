using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents an item in a TO DO list
/// </summary>
public class Task
{
    [Required]
    public int TaskId { get; set; }
    [Required, MaxLength(100)]
    public string TaskTitle { get; set; }
    [Required, MaxLength()]
    public string Details { get; set; }
    [Required]
    public DateTime CompleteBy { get; set; }
    public bool IsDone { get; set; }
    public int TaskTypeId { get; set; }
    public virtual TaskType TaskType { get; set; }
}
