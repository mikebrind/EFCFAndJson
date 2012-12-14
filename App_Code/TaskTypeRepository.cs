using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class TaskTypeRepository
{
    TaskContext db = new TaskContext();
    
    public List<TaskType> GetAllTaskTypes(){
        return db.TaskTypes.ToList();
    }
}
