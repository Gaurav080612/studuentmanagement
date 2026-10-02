namespace StudyTracker;

// A service keeps the application's task-related logic in one place.
public class TaskService
{
    private readonly List<TaskItem> _tasks = [];
    private int _nextId = 1;

    public void Add(string title)
    {
        _tasks.Add(new TaskItem
        {
            Id = _nextId++,
            Title = title.Trim(),
            IsComplete = false
        });
    }

    public List<TaskItem> GetAll() => _tasks;

    public bool MarkComplete(int id)
    {
        var task = _tasks.FirstOrDefault(task => task.Id == id);

        if (task is null)
        {
            return false;
        }

        task.IsComplete = true;
        return true;
    }
}
