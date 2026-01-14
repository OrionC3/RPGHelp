using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Net2025_DemoCleanAsp.Extensions;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models;
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
            return Ok(new { Data = user });
        }


        [HttpGet("self")]
        [Authorize]
        public ActionResult<UserIndexDto> GetUserSelf()
        {
            UserSelfDto user = _userService.GetSelfUser(User.GetId()).ToUserSelfIndexDto();
            return Ok(new { Data = user });
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<List<UserIndexDto>> GetUsers([FromQuery] int page = 0)
        {
            List<UserIndexDto> users = _userService.GetUsers(page)
                .Select(u => u.ToUserIndexDto())
                .ToList();
            return Ok(new { Count = users.Count, Data = users });
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

            // ### Create gest cookies : CookiesHttpOnly 
            var cookieOptions = new CookieOptions()
            {
                // Cookie gest for the server => JS Client don't access at the cookie
                HttpOnly = true,

                // cookie send only https
                Secure = true,

                SameSite = SameSiteMode.Strict,

                // All the 1 hour: the user need relogging
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Add cookie client
            Response.Cookies.Append("accessToken", token, cookieOptions);

            //return Ok(new { token }); OLD version
            return Ok();
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

        [HttpPost("invit-campagn")]
        [Authorize]
        public ActionResult InvitCampagn([FromBody] AddRemoveUserDto dto)
        {
            Console.WriteLine("userId" + dto.userId);
            Console.WriteLine("campagnId" + dto.campagnId);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _userService.InvitCampagn(dto.userId, dto.campagnId, User.GetId());
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

        [HttpPost("remove-player-campagn/")]
        [Authorize]
        public ActionResult RemovePlayerCampagn([FromBody] AddRemoveUserDto dto)
        {
            Console.WriteLine("userId" + dto.userId);
            Console.WriteLine("campagnId" + dto.campagnId);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _userService.LeaveCampagn(dto.userId, dto.campagnId);
            return Created();
        }


        [HttpGet("search")]
        [Authorize]
        public ActionResult SearchUser([FromQuery] string search)
        {
            List<UserIndexDto> uid = _userService.GetUsersByEmail(search).Select(u => u.ToUserIndexDto()).ToList();
            return Ok(new { Data = uid, Count = _userService.Count(search) });
        }

    }
}
