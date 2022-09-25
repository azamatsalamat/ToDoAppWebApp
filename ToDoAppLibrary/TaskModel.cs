namespace ToDoAppLibrary
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Text { get; set; } = String.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public PriorityLevel Priority { get; set; } = PriorityLevel.Low;
        public UserModel? User { get; set; }
    }
}