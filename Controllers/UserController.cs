using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication65.Models;

namespace WebApplication65.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var users = _userService.GetUserById(id);
            if(users == null)
                return NotFound();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user); 
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user) 
        {
            if(id != user.Id)
            {
                return BadRequest();
            }
            _userService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id) 
        {
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
