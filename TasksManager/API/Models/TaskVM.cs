using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class TaskVM
    {
        [Required]
        public string Title { get; set; } = ""; // Nazwa zadania
        public string Description { get; set; } = ""; // Opis zadania

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; } = null; // Termin wykonania (jeśli dotyczy)
        public bool IsCompleted { get; set; } = false; // Czy zadanie zostało wykonane
    }
}
