using ToDoList.Application.DTOs;
using ToDoList.Application.Mappers;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Repositories.TaskRepository;

namespace ToDoList.Application.Services.TaskListService
{
    public class TaskListService : ITaskListService
    {
        private readonly ITaskListRepository _repository;

        public TaskListService(ITaskListRepository repository)
        {
            _repository = repository;
        }

        public Task<List<TaskList>> GetAllTasks()
        {
            return _repository.GetAllAsync();
        }

        public Task<TaskList> GetTaskById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task CreateTask(TaskListDTO dto)
        {
            var task = TaskListMapper.ToEntity(dto);

            return _repository.CreateAsync(task);
        }

        public Task UpdateTask(TaskListDTO dto)
        {
            var task = TaskListMapper.ToEntity(dto);

            return _repository.UpdateAsync(task);
        }

        public Task DeleteTask(int id)
        {
            return _repository.DeleteAsync(id);
        }
    }
}
