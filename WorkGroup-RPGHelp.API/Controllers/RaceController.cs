using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.RaceDto;
using WorkGroup_RPGHelp.API.Services;
using WorkGroup_RPGHelp.BLL.Services;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;

namespace WorkGroup_RPGHelp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService _raceService;

        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpGet]
        public ActionResult<RaceIndexDto> GetRaces([FromQuery] int page = 0)
        {
            List<RaceIndexDto> race = _raceService.GetRaces(page).Select(r => r.ToRaceIndexDto()).ToList();
            return Ok(new { Data = race, Count = _raceService.Count() });
        }

        [HttpGet("{id}")]
        public ActionResult<RaceIndexDto> GetRace([FromRoute] int id)
        {
            RaceIndexDto race = _raceService.GetRace(id).ToRaceIndexDto();
            return Ok(new { Data = race });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Add([FromBody] RaceFormDto form)
        {
            if (form is null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _raceService.Add(form.ToRace());
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _raceService.Delete(id);
            return NoContent();
        }

        [HttpGet("byname")]
        public ActionResult<RaceIndexDto> GetRacesByName([FromQuery] string name)
        {
            List<RaceIndexDto> race = _raceService.GetRacesByName(name).Select(r => r.ToRaceIndexDto()).ToList();
            return Ok(new { Data = race, Count = _raceService.Count(name) });
        }
    }
}
