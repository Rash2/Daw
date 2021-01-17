using Notes_App.Helpers;
using Notes_App.Entities;
using Notes_App.IServices;
using Notes_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var Result = _userService.Register(request);
            if (Result)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        [HttpPost("login")]
        public IActionResult Login(AuthenticationRequest request)
        {
            return Ok(_userService.Login(request));
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var user = (User)HttpContext.Items["User"];
            return Ok(_userService.GetAll().Where(x => x.UserId == user.UserId).ToList());
        }

    }
}
