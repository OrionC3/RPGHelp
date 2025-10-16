using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WorkGroup_RPGHelp.API.Mappers;
using WorkGroup_RPGHelp.API.Models.RaceDto;
using WorkGroup_RPGHelp.API.Services;
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
        public ActionResult<RaceIndexDto> GetRaces()
        {
            List<RaceIndexDto> race = _raceService.GetRaces().Select(r => r.ToRaceIndexDto()).ToList();
            return Ok(race);
        }

        [HttpGet("{id}")]
        public ActionResult<RaceIndexDto> GetRace([FromRoute] int id)
        {
            RaceIndexDto race = _raceService.GetRace(id).ToRaceIndexDto();
            return Ok(race);
        }

        [HttpPost]
        public ActionResult Add([FromBody] RaceFormDto form)
        {
            _raceService.Add(form.ToRace());
            return NoContent();
        }
    }
}
