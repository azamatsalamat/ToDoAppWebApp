using Microsoft.EntityFrameworkCore;
using ToDoAppLibrary;

namespace ToDoAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<TaskListModel> TaskLists { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=" + Directory.GetCurrentDirectory() + @"\Tasks.db");
        }
    }
}
