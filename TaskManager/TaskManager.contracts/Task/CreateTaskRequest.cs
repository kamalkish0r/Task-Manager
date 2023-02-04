namespace TaskManager.Contracts.Task;

public record CreateTaskRequest(
    string Name,
    string Description,
    DateTime DateCreated,
    List<string> Tags);