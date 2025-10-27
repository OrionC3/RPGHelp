using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.SpellsDto;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellController : ControllerBase
    {
        private readonly ISpellService _spellService;

        public SpellController(ISpellService spellService)
        {
           _spellService = spellService;
        }

        [HttpGet]
        public ActionResult<SpellIndexDto> GetSpells(int page = 0)
        {
            List<SpellIndexDto> spell = _spellService.GetSpells(page).Select(s => s.ToSpellIndexDto()).ToList();
            return Ok(spell);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Add([FromBody] SpellFormDto spell)
        {
            if(spell is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _spellService.Add(spell.ToSpell());
            return NoContent();
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Update([FromRoute] int id, [FromBody] SpellFormDto spell)
        {
            if(spell is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _spellService.Update(id, spell.ToSpell());
            return NoContent();
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete([FromRoute] int id)
        {
            _spellService.Delete(id);
            return NoContent();
        }
    }
}