using ToDoAppLibrary;

namespace ToDoAppAPI.Services.UserService
{
    public interface IAuthService
    {
        Task<string> Login(string username, string password);
        Task<int> Register(UserModel user, string password);
        Task<bool> UserExists (string username);
        bool VerifyPasswordHash (string password, byte[] passwordHash, byte[] passwordSalt);

    }
}
