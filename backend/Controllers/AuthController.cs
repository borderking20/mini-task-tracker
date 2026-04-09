using Microsoft.AspNetCore.Mvc;
using backend.DTOs;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController()
        {
            _authService = new AuthService();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto request)
        {
            var user = _authService.ValidateUser(request.Email, request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            var token = _authService.GenerateJwtToken(user);

            return Ok(new { token });
        }
    }
}