using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Contracts.Task;

namespace TaskManager.Controllers;

[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost("/tasks")]
    public IActionResult CreateTask(CreateTaskRequest request)
    {
        var task = new Task(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.DateCreated,
            request.Tags
        );

        var response = new TaskResponse(
            task.Id,
            task.Name,
            task.Des
        )
        return Ok(request);
    }

    [HttpGet("/tasks/{id:guid}")]
    public IActionResult GetTask(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/tasks/{id:guid}")]
    public IActionResult UpdateTask(Guid id, UpdateTaskRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/tasks/{id:guid}")]
    public IActionResult DeleteTask(Guid id)
    {
        return Ok(id);
    }
}