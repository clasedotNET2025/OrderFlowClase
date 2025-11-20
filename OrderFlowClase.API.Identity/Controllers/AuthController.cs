using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace OrderFlowClase.API.Identity.Controllers
{
    [ApiVersion(1)]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class AuthController : Controller
    {
        private IEnumerable<User> _users = new List<User>();

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            _users.ToList().Add(user);
            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (existingUser != null)
            {
                return Ok("Login successful");
            }
            return Unauthorized("Invalid credentials");
        }       
    }
    public class User
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
