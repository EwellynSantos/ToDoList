using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Services.TaskListService
{
    public interface ITaskListService
    {
        Task<List<TaskList>> GetAllTasks();
        Task<TaskList> GetTaskById(int id);
        Task CreateTask(TaskListDTO dto);
        Task UpdateTask(TaskListDTO dto);
        Task DeleteTask(int id);

    }
}
