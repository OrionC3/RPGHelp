using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Net2025_DemoCleanAsp.Extensions;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.CampagnDto;
using WorkGroup_RPGHelp.API.Models.CharacteresDto;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactereController : ControllerBase
    {
        private readonly ICharactereService _charactereService;

        public CharactereController(ICharactereService charactereService)
        {
            _charactereService = charactereService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult GetAllCharactereByUserId(int page = 0)
        {
            List<Charactere> c = [.. _charactereService.GetCharacteresByUserId(User.GetId(), page)];
            List<CharactereIndexDto> cidto = [.. c.Select(c => c.ToCharactereIndexDto())];
            return Ok(cidto);
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult GetCharactereById([FromRoute] int id)
        {
            CharactereDetailsDto c = _charactereService.GetCharactereById(id).ToCharactereDetailsDto();
            return Ok(c);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddCharactere([FromBody] CharactereFormDto form)
        {
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            Charactere charactere = form.ToCharactere();
            charactere.Id = User.GetId();
            charactere.CampagnId = null;

            Charactere id = _charactereService.Add(charactere);
            return Ok(id);
        }

        [HttpPut("{id}")]
        [Authorize]
        public ActionResult UpdateCharactere([FromRoute] int id, [FromBody] CharactereFormDto form)
        {
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _charactereService.Update(id, form.ToCharactere(), User.GetId());
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public ActionResult Delete([FromRoute] int id)
        {
            _charactereService.Delete(id, User.GetId());
            return NoContent();
        }

        [HttpPost("sign-up-campagn/{charactereId}&{campagnId}")]
        [Authorize]
        public ActionResult SignUpCampagn([FromRoute] int charactereId, [FromRoute] int campagnId)
        {
            _charactereService.SignUpCampagn(charactereId, campagnId);
            return Created();
        }
    }
}
