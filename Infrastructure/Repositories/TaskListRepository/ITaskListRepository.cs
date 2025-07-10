using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.Repositories.TaskRepository
{
    public interface ITaskListRepository
    {
        Task<List<TaskList>> GetAllAsync();
        Task<TaskList> GetByIdAsync(int id);
        Task CreateAsync(TaskList task);
        Task UpdateAsync(TaskList task);
        Task DeleteAsync(int id);
    }
}
