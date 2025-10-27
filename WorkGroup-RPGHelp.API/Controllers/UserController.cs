using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Net2025_DemoCleanAsp.Extensions;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.UsersDto;
using WorkGroup_RPGHelp.API.Services;
using WorkGroup_RPGHelp.BLL.Exceptions.User;
using WorkGroup_RPGHelp.BLL.Services;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AuthService _authService;

        public UserController(IUserService userService, AuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<UserIndexDto> GetUser([FromRoute] int id)
        {
            UserIndexDto user = _userService.GetUser(id).ToUserIndexDto();
            return Ok(user);
        }


        [HttpGet("/self")]
        [Authorize]
        public ActionResult<UserIndexDto> GetUserSelf()
        {
            UserSelfDto user = _userService.GetSelfUser(User.GetId()).ToUserSelfIndexDto();

            return Ok(user);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
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
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
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

            string token = _authService.GenerateToken(user);

            return Ok(new { token });
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete([FromRoute] int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
        
        [HttpPost("join-campagn/")]
        [Authorize]
        public ActionResult JoinCampagn([FromBody] int campagnId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _userService.JoinCampagn(User.GetId(), campagnId);
            return Created();
        }

        [HttpPost("invit-campagn/{userId}")]
        [Authorize]
        public ActionResult InvitCampagn([FromRoute] int userId, [FromBody] int campagnId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _userService.InvitCampagn(userId, campagnId, User.GetId());
            return Created();
        }

        [HttpPost("leave-campagn/")]
        [Authorize]
        public ActionResult LeaveCampagn([FromBody] int campagnId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _userService.LeaveCampagn(User.GetId(), campagnId);
            return Created();
        }
    }
}
