using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.UsersDto;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Controllers
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
        public ActionResult<List<UserIndexDto>> GetUsers([FromQuery] int page = 0)
        {
            List<UserIndexDto> users = _userService.GetUsers(page)
                .Select(u => u.ToUserIndexDto())
                .ToList();
            return Ok(users);
        }

        [HttpPost("register")]

        public IActionResult Register([FromBody] UserFormDto form)
        {
            _userService.Add(form.ToUser());

            return NoContent();
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] UserFormDto loginform)
        {
            if(loginform is null ||!ModelState.IsValid)
            {
                return BadRequest();
            }
            Users user = _userService.Login(loginform.Email, loginform.Password);

            // To do - Create Token authentication
            return Ok();
        }
    }
}
