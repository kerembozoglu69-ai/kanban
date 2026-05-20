using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanban.Models
{
    public class KanbanTask
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        
        [Required]
        public string Status { get; set; } = "Yapılacak"; // Yapılacak, Yapılıyor, Bitti
        
        public TaskPriority Priority { get; set; } = TaskPriority.Normal;
        
        public DateTime? DueDate { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public int Order { get; set; } = 0;

        // Relation to User
        public string? AssignedToUserId { get; set; }
        
        [ForeignKey("AssignedToUserId")]
        public virtual ApplicationUser? AssignedToUser { get; set; }
    }
}
