using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Mappers
{
    public static class TaskListMapper
    {
        public static TaskListDTO ToDTO(TaskList taskList)
        {
            if (taskList == null) return null;

            return new TaskListDTO
            {
                Id = taskList.Id,
                UserId = taskList.UserId,
                Title = taskList.Title,
                Description = taskList.Description,
                DeadLine = taskList.DeadLine,
                Priority = taskList.Priority,
                StatusTask = taskList.StatusTask,
                CreatedDate = taskList.CreatedDate,
                UpdateDate = taskList.UpdateDate
            };
        }

        public static TaskList ToEntity(TaskListDTO dto)
        {
            if (dto == null) return null;

            return new TaskList
            {
                Id = dto.Id,
                UserId = dto.UserId,
                Title = dto.Title,
                Description = dto.Description,
                DeadLine = dto.DeadLine,
                Priority = dto.Priority,
                StatusTask = dto.StatusTask,
                CreatedDate = dto.CreatedDate,
                UpdateDate = dto.UpdateDate
            };
        }
    }
}
