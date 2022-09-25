using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDoAppAPI.Dtos;
using ToDoAppAPI.Services.TaskService;
using ToDoAppLibrary;

namespace ToDoAppAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<TaskModel>>> GetAllTasks()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return await _taskService.GetAllTasks(userId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModel>> GetTaskById(int id)
        {
            return await _taskService.GetTaskById(id);
        }

        [HttpPost]
        public async Task<ActionResult<List<TaskModel>>> CreateTask(CreateTaskDto request)
        {
            return await _taskService.CreateNewTask(request);
        }
    }
}
