using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.Repositories.UserRepositoty
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task CreateAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
