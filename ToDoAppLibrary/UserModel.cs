namespace ToDoAppLibrary
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
