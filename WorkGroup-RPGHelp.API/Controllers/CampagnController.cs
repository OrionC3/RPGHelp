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
        public ActionResult GetAllCampagn() 
        {
            List<Campagn> c = [.. _campagnService.GetCampagns()];
            List<CampagnIndexDto> cidto = [.. c.Select(c => c.ToCampagnIndexDto())];
            List<CampagnIndexDto> cidto2 = _campagnService.GetCampagns().Select(c => c.ToCampagnIndexDto()).ToList();
            return Ok(cidto);
        }

        [HttpGet("{id}")]
        public ActionResult GetCampagn([FromRoute] int id)
        {
            CampagnIndexDto c = _campagnService.GetCampagnById(id).ToCampagnIndexDto();
            return Ok(c);
        }

        [HttpPost]
        public ActionResult AddCampagn([FromBody] CampagnFormDto form)
        {
            _campagnService.Add(form.ToCampagn());
            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCampagn([FromRoute] int id, [FromBody] CampagnFormDto form)
        {
            _campagnService.Update(id, form.ToCampagn());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _campagnService.Delete(id);
            return NoContent();
        }
    }
}
