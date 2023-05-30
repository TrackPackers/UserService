using Microsoft.AspNetCore.Mvc;
using UserService.Models;
using UserService.Services.Interfaces;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }
        
        [HttpDelete("/delete")]
        public async Task<ActionResult<String>> deleteUser([FromBody] UserBody userBody)
        {
            return await _userService.deleteUser(userBody);
        }
    }
}
