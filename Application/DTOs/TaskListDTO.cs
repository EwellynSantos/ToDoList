using ToDoList.Domain.Entities;
using ToDoList.Domain.Enums;

namespace ToDoList.Application.DTOs
{
    public class TaskListDTO
    {
        public int Id { get; set; } //PK
        public int? UserId { get; set; } //FK
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DeadLine { get; set; }
        public Priority? Priority { get; set; }
        public StatusTask? StatusTask { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
    }
}
