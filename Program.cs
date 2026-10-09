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

        Task myTask = CreateNewToDo(name, descr, taskData);

        Console.WriteLine(myTask.ToString());


        static Task CreateNewToDo(string taskName, string taskDescr, List<Task> taskData)
        {
            Task task = new Task(taskName, taskDescr);

            taskData.Add(task);

            return task;

        }

    }
}
