using ToDoAppAPI.Dtos;
using ToDoAppLibrary;

namespace ToDoAppAPI.Services.TaskService
{
    public interface ITaskService
    {
        Task<List<TaskModel>> GetAllTasks(int userId);
        Task<TaskModel> GetTaskById(int taskId);
        Task<List<TaskModel>> GetTasksByDateAscending(string name);
        Task<List<TaskModel>> GetTasksByPriorityDescending(string name);
        Task<List<TaskModel>> GetTasksFromList(int listId);
        Task<List<TaskModel>> CreateNewTask(CreateTaskDto request);

    }
}
