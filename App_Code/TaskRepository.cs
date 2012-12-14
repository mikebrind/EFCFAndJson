using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Centralises data operations for Task objects
/// </summary>
public class TaskRepository
{
    TaskContext db = new TaskContext();

    public Task Save(Task task) {
        task.TaskType = db.TaskTypes.Find(task.TaskTypeId);
        if (task.TaskId == 0) {
            db.Tasks.Add(task);
        }
        else {
            var t = db.Tasks.Find(task.TaskId);
            if(task.IsDone){
                t.IsDone = task.IsDone;
            } else {
                t.TaskTitle = task.TaskTitle;
                t.Details = task.Details;
                t.CompleteBy = task.CompleteBy;
                t.TaskType = task.TaskType;
            }
        }
        db.SaveChanges();
        return db.Tasks.Find(task.TaskId);
    }



    public List<Task> GetAllTasks(){
        return db.Tasks.ToList();
    }
}
