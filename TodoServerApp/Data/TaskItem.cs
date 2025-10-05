namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Discription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
