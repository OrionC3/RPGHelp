using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Net2025_DemoCleanAsp.Extensions;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.CampagnDto;
using WorkGroup_RPGHelp.API.Models.CharacteresDto;
using WorkGroup_RPGHelp.API.Models.UsersDto;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampagnController : ControllerBase
    {
        private readonly ICampagnService _campagnService;

        public CampagnController(ICampagnService campagnService)
        {
            _campagnService = campagnService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetAllCampagn() 
        {
            List<Campagn> c = [.. _campagnService.GetCampagns()];
            List<CampagnIndexDto> cidto = [.. c.Select(c => c.ToCampagnIndexDto())];
            return Ok(cidto);
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult GetCampagn([FromRoute] int id)
        {
            CampagnIndexDto c = _campagnService.GetCampagnById(id).ToCampagnIndexDto();
            return Ok(c);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddCampagn([FromBody] CampagnFormDto form)
        {
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _campagnService.Add(form.ToCampagn(), User.GetId());
            return Created();
        }

        [HttpPut("{id}")]
        [Authorize]
        public ActionResult UpdateCampagn([FromRoute] int id, [FromBody] CampagnFormDto form)
        {
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _campagnService.Update(id, form.ToCampagn());
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public ActionResult Delete([FromRoute] int id)
        {
            _campagnService.Delete(id);
            return NoContent();
        }

        [HttpPut("changegm/{id}")]
        [Authorize]
        public ActionResult ChangeGM([FromBody] int userID, [FromRoute] int campagnId)
        {
            _campagnService.ChangeGM(User.GetId(), userID, campagnId);
            return NoContent();
        }
    }
}
