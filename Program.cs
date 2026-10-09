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

}

public class Program{
    
    static void Main(string[] args)
    {
        
        Task task = new Task("Escrever", "Escrever livro");


        Console.WriteLine(task.TaskName);
        Console.WriteLine(task.TaskDescription);
        Console.WriteLine(task.IsCompleted);
        Console.WriteLine(task.CreatedAt);


    }

}
