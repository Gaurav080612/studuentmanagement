using StudyTracker;

var taskService = new TaskService();
var running = true;

Console.WriteLine("====================================");
Console.WriteLine("       Welcome to Study Tracker      ");
Console.WriteLine("====================================");

while (running)
{
    ShowMenu();
    Console.Write("Choose an option (1-4): ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddTask(taskService);
            break;
        case "2":
            ShowTasks(taskService);
            break;
        case "3":
            CompleteTask(taskService);
            break;
        case "4":
            running = false;
            Console.WriteLine("Good luck with your studies. Goodbye!");
            break;
        default:
            Console.WriteLine("Please enter a number from 1 to 4.");
            break;
    }

    Console.WriteLine();
}

static void ShowMenu()
{
    Console.WriteLine("1. Add a study task");
    Console.WriteLine("2. View all tasks");
    Console.WriteLine("3. Mark a task as complete");
    Console.WriteLine("4. Exit");
}

static void AddTask(TaskService taskService)
{
    Console.Write("What would you like to study? ");
    var title = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(title))
    {
        Console.WriteLine("A task needs a name.");
        return;
    }

    taskService.Add(title);
    Console.WriteLine("Task added successfully!");
}

static void ShowTasks(TaskService taskService)
{
    var tasks = taskService.GetAll();

    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks yet. Add your first one!");
        return;
    }

    Console.WriteLine("\nYour study tasks:");
    foreach (var task in tasks)
    {
        var status = task.IsComplete ? "Done" : "To do";
        Console.WriteLine($"{task.Id}. [{status}] {task.Title}");
    }
}

static void CompleteTask(TaskService taskService)
{
    ShowTasks(taskService);
    Console.Write("Enter the task number to complete: ");

    if (!int.TryParse(Console.ReadLine(), out var id))
    {
        Console.WriteLine("Please enter a valid task number.");
        return;
    }

    Console.WriteLine(taskService.MarkComplete(id)
        ? "Nice work! Task marked as complete."
        : "That task number was not found.");
}
