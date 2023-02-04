namespace TaskManager.Contracts.Task;

public record UpdateTaskRequest(
    Guid Id,
    string Name,
    string Description,
    DateTime DateCreated,
    List<string> tags);