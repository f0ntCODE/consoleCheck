namespace task
{
    public class ToDo
    {
        private string _taskName { get; set; }
        private string _taskDescription { get; set; }
        private bool _isCompleted = false;
        private DateOnly _createdAt;

        public ToDo(string name, string description)
        {
            _taskName = name;
            _taskDescription = description;
            _createdAt = DateOnly.FromDateTime(DateTime.Now);
        }

        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        public string TaskDescription
        {
            get { return _taskDescription; }
            set { _taskDescription = value; }
        }

        public bool IsCompleted
        {
            set { _isCompleted = value; }
            get { return _isCompleted; }
        }

        public DateOnly CreatedAt
        {
            get { return _createdAt; }
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
}