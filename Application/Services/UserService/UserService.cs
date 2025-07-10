using ToDoList.Application.DTOs;
using ToDoList.Application.Mappers;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Repositories.UserRepositoty;

namespace ToDoList.Application.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public Task<List<User>> GetAllUsers()
        {
            return _repository.GetAllAsync();
        }

        public Task<User> GetUserById(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task CreateUser(UserDTO dto)
        {

            var user = UserMapper.ToEntity(dto);

            return _repository.CreateAsync(user);
        }

        public Task UpdateUser(UserDTO dto)
        {
            var user = UserMapper.ToEntity(dto);

            return _repository.UpdateAsync(user);
        }

        public Task DeleteUser(int id)
        {
            return _repository.DeleteAsync(id);
        }
    }
}
