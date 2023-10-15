using Microsoft.AspNetCore.Mvc;

namespace WebTodoApp.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ILogger<TaskController> _logger;

    public TaskController(ILogger<TaskController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "tasks")]
    public IEnumerable<Task> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Task
            {
                Title = "Hello",
                Description = "World",
                Status = Random.Shared.Next(0, 2)
            })
            .ToArray();
    }
}