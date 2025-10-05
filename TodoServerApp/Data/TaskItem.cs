using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Discription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
