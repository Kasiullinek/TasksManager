using API.Models;

namespace API.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationbuilder)
        {
            using (var serviceScope = applicationbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Tasks.Any())
                {
                    context.Tasks.AddRange(
                        new TaskModel
                        {
                            Title = "Prepare project documentation",
                            Description = "Write technical and user documentation for the project.",
                            DueDate = DateTime.Parse("2025-05-10"),
                            IsCompleted = false
                        },
                        new TaskModel
                        {
                            Title = "Fix login bug",
                            Description = "Resolve the issue causing login failure on Safari browsers.",
                            DueDate = DateTime.Parse("2025-05-05"),
                            IsCompleted = false
                        },
                        new TaskModel
                        {
                            Title = "Team meeting",
                            Description = "Schedule and conduct the sprint planning meeting.",
                            DueDate = DateTime.Parse("2025-04-01"),
                            IsCompleted = true
                        }
                    );

                    context.SaveChanges();
                }

            }
        }
    }
}
