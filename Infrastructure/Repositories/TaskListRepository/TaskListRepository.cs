using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;
using ToDoList.Infrastructure.Data;

namespace ToDoList.Infrastructure.Repositories.TaskRepository
{
    public class TaskListRepository : ITaskListRepository
    {
        private readonly AppDbContext _context;

        public TaskListRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskList>> GetAllAsync()
        {
            return await _context.TaskList.ToListAsync();
        }

        public async Task<TaskList> GetByIdAsync(int id)
        {
            return await _context.TaskList.FindAsync(id);
        }

        public async Task CreateAsync(TaskList task)
        {
            await _context.TaskList.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TaskList task)
        {
            _context.TaskList.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var task = await _context.TaskList.FindAsync(id);
            if (task != null)
            {
                _context.TaskList.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
