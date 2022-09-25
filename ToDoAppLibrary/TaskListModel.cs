namespace ToDoAppLibrary
{
    public class TaskListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
