using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAllCampagn() 
        {
            List<Campagn> c = [.. _campagnService.GetCampagns()];
            List<CampagnIndexDto> cidto = c.Select(c => c.ToCampagnIndexDto()).ToList();
            return Ok();
        }
    }
}
