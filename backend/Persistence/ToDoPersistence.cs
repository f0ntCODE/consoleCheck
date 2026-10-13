using System;
using task;

namespace consoleCheck.Persistence;

public class ToDoPersistence
{
     
    private Dictionary<int, ToDo> taskPersistence = new Dictionary<int, ToDo>();
    int id = 0;

    public void saveTask(ToDo toDo)
    {
        taskPersistence.Add(++id, toDo);
    }

    public List<ToDo> ListAll()
    {
        
        return new List<ToDo>(taskPersistence.Values);
    }

}
