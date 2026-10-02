# Study Tracker

A small command-line app for tracking study tasks. It is designed as a friendly first .NET project: the code is intentionally separated into a program entry point, a data model, and a service class.

## What it can do

- Add a study task
- Display every task and its status
- Mark a task as complete

## Run it

1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).
2. Open a terminal in this folder.
3. Run:

```powershell
dotnet run
```

## Project structure

| File | Purpose |
| --- | --- |
| `Program.cs` | Shows the menu and reads user input. |
| `TaskItem.cs` | Defines what one study task looks like. |
| `TaskService.cs` | Contains task operations such as adding and completing tasks. |

## Suggested next challenges

1. Add a due date to `TaskItem`.
2. Let users delete a task.
3. Save tasks to a JSON file so they remain after the app closes.
4. Add unit tests for `TaskService`.
