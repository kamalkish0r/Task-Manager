namespace TaskManager.Contracts.Task;

public record TaskResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime DateCreated,
    List<string> tags);