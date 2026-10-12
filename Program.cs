// Creating a todo list using list data structure

public class Task
{
    private string _taskName {get; set;}
    private string _taskDescription {get; set;}
    private bool _isCompleted = false;
    private DateOnly _createdAt;
    
    public Task(string name, string description)
    {
        _taskName = name;
        _taskDescription = description;
        _createdAt = DateOnly.FromDateTime(DateTime.Now);
    }

    public string TaskName
    {
        get {return _taskName;}
        set {_taskName = value;}    
    }

    public string TaskDescription
    {
        get{return _taskDescription;}
        set{_taskDescription = value;}
    }

    public bool IsCompleted
    {
        set {_isCompleted = value;}
        get {return _isCompleted;}
    }

    public DateOnly CreatedAt
    {
        get {return _createdAt;}
    }

    public override string ToString()
    {
        return $"""
            [task name]: {_taskName};
            [task description]: {_taskDescription};
            [created at]: {_createdAt}
        """;
    }

}

public class Program{

    static void Main(string[] args)
    {

        List<Task> taskData = new List<Task>();

        Console.Write("Type list name: ");
        string name = Console.ReadLine();
        
        Console.Write("\nType list description: ");
        string descr = Console.ReadLine();

        CreateNewToDo(name, descr, taskData);

        Console.WriteLine("\n Consulting list by index: " + taskData[0]);

        EditToDo(0, "New name fo task", "New task description", taskData);

        Console.WriteLine("\n Task with new info: " + taskData[0]);

        DeleteToDo(0, taskData);

        Console.WriteLine("Task deleted");


        static Task CreateNewToDo(string taskName, string taskDescr, List<Task> taskData)
        {
            Task task = new Task(taskName, taskDescr);

            taskData.Add(task);

            return task;

        }

        static Task EditToDo(int index, string? newName, string? taskDescr, List<Task> taskData)
        {
            Task task = taskData[index];

            if (!newName.Equals(""))
            {
                task.TaskName = newName;
            }
            if (!taskDescr.Equals(""))
            {
                task.TaskDescription = taskDescr;
            }

            return task;
            
        }

        static void DeleteToDo(int index, List<Task> taskData)
        {
            Task task = taskData[index];
            taskData.Remove(task);
            
        }

    }
}
