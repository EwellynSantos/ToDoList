using ToDoList.Domain.Enums;

namespace ToDoList.Domain.Entities
{
    public class TaskList
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

        public User? User { get; set; }
    }
}
