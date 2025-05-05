using CarbonQuest.API.Models;
using CarbonQuest.API.Services;
using CarbonQuest.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarbonQuest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly UserService _userService;

        public LoginController()
        {
            _userService = new UserService(new UserRepository());
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null) return BadRequest("Request tidak boleh null.");

            var user = _userService.Login(request.Username, request.Password);

            if (user == null)
                return Unauthorized("Username atau password salah.");

            return Ok(new { message = $"Selamat datang, {user.Username}!" });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (request == null) return BadRequest("Request tidak boleh null.");

            try
            {
                _userService.Register(request.Username, request.Password);
                return Ok(new { message = "User berhasil didaftarkan." });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("current")]
        public IActionResult GetCurrentUser()
        {
            var user = _userService.GetActiveUser();
            if (user == null)
                return NotFound("Tidak ada user yang aktif.");

            return Ok(user);
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            _userService.Logout();
            return Ok(new { message = "User berhasil logout." });
        }
    }

    // Request DTO
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class RegisterRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
