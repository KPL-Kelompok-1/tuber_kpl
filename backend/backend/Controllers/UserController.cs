using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Model;
using backend.Config;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserConfig userConfig = new UserConfig();

        //login api
        [HttpPost("login")]
        public ActionResult<user> Login([FromBody] user user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data provided.");
            }

            // Validate username and password (consider more complex validation)
            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password))
            {
                return Unauthorized("Invalid username or password.");
            }
            var users = userConfig.LoadConfig();
            foreach (var u in users)
            {
                if (u.username == user.username && u.password == user.password)
                {
                    return u;
                }
            }
            return null;
        }


        [HttpGet]
        public ActionResult<List<user>> Get()
        {
            return userConfig.LoadConfig();
        }

        [HttpGet("{id}")]
        public ActionResult<List<Forum>> GetById(int id)
        {
            return ForumConfig.LoadConfig(id);
        }

        [HttpPost("register")]
        public ActionResult<user> Post([FromBody] user user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data provided.");
            }

            // Validate user properties (consider custom validation logic)
            if (string.IsNullOrEmpty(user.username) || user.username.Length > 10)
            {
                return BadRequest("Username is required and cannot exceed 10 characters.");
            }

            if (string.IsNullOrEmpty(user.password) || user.password.Length < 8)
            {
                return BadRequest("Password is required and must be at least 8 characters long.");
            }

            userConfig.add(user);
            userConfig.SaveConfig();
            return user;
        }

        [HttpPut]
        public ActionResult Put([FromBody] user user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data provided.");
            }

            // Validate user properties (consider custom validation logic)
            if (string.IsNullOrEmpty(user.username) || user.username.Length > 10)
            {
                return BadRequest("Username is required and cannot exceed 10 characters.");
            }

            if (string.IsNullOrEmpty(user.password) || user.password.Length < 8)
            {
                return BadRequest("Password is required and must be at least 8 characters long.");
            }
            userConfig.edit(user);
            userConfig.SaveConfig();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            userConfig.delete(id);
            userConfig.SaveConfig();
            return Ok();
        }
        
    }
}
