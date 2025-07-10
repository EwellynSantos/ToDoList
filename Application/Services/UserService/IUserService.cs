using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task CreateUser(UserDTO dto);
        Task UpdateUser(UserDTO dto);
        Task DeleteUser(int id);
    }
}
