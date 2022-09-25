using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAppAPI.Dtos;
using ToDoAppAPI.Services.UserService;
using ToDoAppLibrary;

namespace ToDoAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<int> Register(UserRegisterDto request)
        {
            var user = new UserModel { Username = request.Username };

            return await _authService.Register(user, request.Password);
        }

        [HttpPost("login")]
        public async Task<string> Login(UserLoginDto request)
        {
            return await _authService.Login(request.Username, request.Password);
        }
    }
}
