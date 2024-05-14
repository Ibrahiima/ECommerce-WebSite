using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace E_commerce.Controllers.UserController
{
    [ApiController]
    [Route("api/UserController/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTOs>>> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            if (users == null)
            {
                   return Ok(new List<UserDTOs>()); 
            }
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTOs>> GetUserById(string id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTOs>> CreateUser(UserDTOs userDTO)
        {
            var createdUser = await _userService.CreateAsync(userDTO);
          
            return Ok(createdUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, UserDTOs userDTO)
        {
            var existingDto = await _userService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _userService.UpdateAsync(userDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }


}

