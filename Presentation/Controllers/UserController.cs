using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Application.DTOs;
using ToDoList.Application.Services;
using ToDoList.Application.Services.UserService;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Data;

namespace ToDoList.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            try
            {
                var user = await _service.GetUserById(id);

                return Ok(user);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetAll()
        {
            try
            {
                return Ok(await _service.GetAllUsers());

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody] UserDTO dto)
        {
            try
            {
                await _service.CreateUser(dto);
                return Ok();

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<User>> Update([FromBody] UserDTO dto)
        {
            try
            {
                await _service.UpdateUser(dto);
                return Ok();

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteUser(id);
                return Ok();

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
