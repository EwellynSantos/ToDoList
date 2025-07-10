using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToDTO(User user)
        {
            if (user == null) return null;

            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                CreatedDate = user.CreatedDate,
                UpdateDate = user.UpdateDate,
                Status = user.Status
            };
        }

        public static User ToEntity(UserDTO dto)
        {
            if (dto == null) return null;

            return new User
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                CreatedDate = dto.CreatedDate,
                UpdateDate = dto.UpdateDate,
                Status = dto.Status
            };
        }
    }
}
