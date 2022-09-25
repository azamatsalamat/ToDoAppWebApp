using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ToDoAppAPI.Data;
using ToDoAppAPI.Dtos;
using ToDoAppLibrary;

namespace ToDoAppAPI.Services.TaskService
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        private List<TaskModel> tasks = new List<TaskModel>
        {
            new TaskModel{Id = 1, Text ="Do smth"}
        };

        public TaskService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<TaskModel>> CreateNewTask(CreateTaskDto request)
        {
            var newTask = _mapper.Map<TaskModel>(request);
            await _context.Tasks.AddAsync(newTask);
            await _context.SaveChangesAsync();
            return await _context.Tasks.ToListAsync();
        }

        public async Task<List<TaskModel>> GetAllTasks(int userId)
        {
            return await _context.Tasks.Where(x => x.User.Id == userId).ToListAsync();
        }

        public async Task<TaskModel> GetTaskById(int taskId)
        {
            return tasks.FirstOrDefault(x => x.Id == taskId);
        }

        public async Task<List<TaskModel>> GetTasksByDateAscending(string name)
        {
            return tasks.OrderBy(x => x.Date).ToList();
        }

        public async Task<List<TaskModel>> GetTasksByPriorityDescending(string name)
        {
            return tasks.OrderByDescending(x => x.Priority).ToList();
        }

        public Task<List<TaskModel>> GetTasksFromList(int listId)
        {
            throw new NotImplementedException();
        }
    }
}
