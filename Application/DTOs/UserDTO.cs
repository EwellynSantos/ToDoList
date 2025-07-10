namespace ToDoList.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; } //PK
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public string? Status { get; set; }
    }
}
