using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        public TasksService _tasksService;

        public TasksController(TasksService tasksService)
        {
            _tasksService = tasksService;
        }

        [HttpGet("get-all-tasks")]
        public IActionResult GetAllTasks()
        {
            var allAssets = _tasksService.GetAllTasks();
            return Ok(allAssets);
        }

        [HttpGet("get-task/{Id}")]
        public IActionResult GetTask(int Id)
        {
            var asset = _tasksService.GetTask(Id);
            return Ok(asset);
        }

        [HttpPost("add-task")]
        public IActionResult AddTask([FromBody] TaskVM task)
        {
            _tasksService.AddTask(task);
            return Ok();
        }

        [HttpPut("update-task/{id}")]

        public IActionResult UpdateTask(int id, [FromBody] TaskVM task)
        {
            var updatedTask = _tasksService.UpdateTask(id, task);
            return Ok(updatedTask);
        }

        [HttpDelete("remove-task/{id}")]

        public IActionResult DeleteTask(int id)
        {
            _tasksService.DeleteTask(id);
            return Ok();
        }
    }
}
