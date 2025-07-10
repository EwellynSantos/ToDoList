using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.DTOs;
using ToDoList.Application.Services.TaskListService;
using ToDoList.Domain.Entities;

namespace ToDoList.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskListController : ControllerBase
    {
        private readonly ITaskListService _service;

        public TaskListController(ITaskListService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskList>> GetById(int id)
        {
            try
            {
                var task = await _service.GetTaskById(id);
                return Ok(task);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<TaskList>> GetAll()
        {
            try
            {
                return Ok(await _service.GetAllTasks());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<TaskList>> Create(TaskListDTO dto)
        {
            try
            {
                await _service.CreateTask(dto);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<TaskList>> Update(TaskListDTO dto)
        {
            try
            {
                await _service.UpdateTask(dto);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteTask(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
