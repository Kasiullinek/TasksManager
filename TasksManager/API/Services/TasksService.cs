using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Services
{
    public class TasksService
    {
        private AppDbContext _context;

        public TasksService(AppDbContext context)
        {
            _context = context;
        }

        public List<TaskModel> GetAllTasks()
        {
            return _context.Tasks.OrderByDescending(a => a.Id).ToList();
        }

        public TaskModel GetTask(int taskId)
        {
            return _context.Tasks.FirstOrDefault(n => n.Id == taskId);
        }

        public void AddTask(TaskVM task)
        {
            var _task = new TaskModel()
            {
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate ?? DateTime.Now,
                IsCompleted = task.IsCompleted,
            };
            _context.Tasks.Add(_task);
            _context.SaveChanges();
        }

        public TaskModel UpdateTask(int taskId, TaskVM task)
        {
            var _task = _context.Tasks.FirstOrDefault(n => n.Id == taskId);

            if (_task != null)
            {
                _task.Title = task.Title;
                _task.Description = task.Description;
                _task.DueDate = task.DueDate;
                _task.IsCompleted = task.IsCompleted;

                _context.SaveChanges();
            }

            return _task;
        }

        public void DeleteTask(int taskId)
        {
            var _task = _context.Tasks.FirstOrDefault(n => n.Id == taskId);

            if (_task != null)
            {
                _context.Tasks.Remove(_task);
                _context.SaveChanges();
            }
        }
    }
}
