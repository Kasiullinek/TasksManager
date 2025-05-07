namespace API.Models
{
    public class TaskModel
    {
        public int Id { get; set; } // Unikalny identyfikator
        public string Title { get; set; } = ""; // Nazwa zadania
        public string Description { get; set; } = ""; // Opis zadania
        public DateTime? DueDate { get; set; } = null; // Termin wykonania (jeśli dotyczy)
        public bool IsCompleted { get; set; } = false; // Czy zadanie zostało wykonane
    }
}
