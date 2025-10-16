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
        public ActionResult GetAllCharactereByUserId()
        {
            List<Charactere> c = [.. _charactereService.GetCharacteresByUserId(User.GetId())];
            List<CharactereIndexDto> cidto = [.. c.Select(c => c.ToCharactereIndexDto())];
            return Ok(cidto);
        }

        [HttpGet("{id}")]
        //[Authorize]
        public ActionResult GetCharactereById([FromRoute] int id)
        {
            CharactereDetailsDto c = _charactereService.GetCharactereById(id).ToCharactereDetailsDto();
            return Ok(c);
        }

        [HttpPost]
        //[Authorize]
        public ActionResult AddCharactere([FromBody] CharactereFormDto form)
        {
            _charactereService.Add(form.ToCharactere());
            return Created();
        }

        [HttpPut("{id}")]
        //[Authorize]
        public ActionResult UpdateCharactere([FromRoute] int id, [FromBody] CharactereFormDto form)
        {
            _charactereService.Update(id, form.ToCharactere());
            return NoContent();
        }

        [HttpDelete("{id}")]
        //[Authorize]
        public ActionResult Delete([FromRoute] int id)
        {
            _charactereService.Delete(id);
            return NoContent();
        }

        [HttpPost("sign-up-campagn/{charactereId}&{campagnId}")]
        public ActionResult SignUpCampagn([FromRoute] int charactereId, [FromRoute] int campagnId)
        {
            _charactereService.SignUpCampagn(charactereId, campagnId);
            return Created();
        }
    }
}
