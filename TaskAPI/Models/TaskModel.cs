using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
