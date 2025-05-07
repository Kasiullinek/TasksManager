using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class TaskVM
    {
        public string Title { get; set; } = ""; // Nazwa zadania
        public string Description { get; set; } = ""; // Opis zadania
        public DateTime? DueDate { get; set; } = null; // Termin wykonania (jeśli dotyczy)
        public bool IsCompleted { get; set; } = false; // Czy zadanie zostało wykonane
    }
}
