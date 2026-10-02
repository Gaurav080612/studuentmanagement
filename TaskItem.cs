namespace StudyTracker;

// A model represents the data used by the application.
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}
