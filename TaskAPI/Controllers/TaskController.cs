using Microsoft.AspNetCore.Mvc;
using TaskAPI.Data;
using TaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskAPI.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskDbContext _context;

        public TaskController(TaskDbContext context)
        {
            _context = context;
        }

        // GET: api/task
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskModel>>> GetTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        // POST: api/task
        [HttpPost]
        public async Task<ActionResult<TaskModel>> AddTask(TaskModel task)
        {
            if (string.IsNullOrWhiteSpace(task.Name))
            {
                return BadRequest(new { message = "El nombre de la tarea es obligatorio" });
            }

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
        }

        // DELETE: api/task/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
