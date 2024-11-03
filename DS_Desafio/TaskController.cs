using DS_Desafio;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly TaskDb _context;

    public TaskController(TaskDb context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddTask([FromBody] TaskModel newTask)
    {
        _context.Tasks.Add(newTask);
        await _context.SaveChangesAsync();
        return Ok(newTask);
    }
}