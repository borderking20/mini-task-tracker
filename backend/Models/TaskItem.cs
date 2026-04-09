using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public enum Status
    {
        Pending,
        Done
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}