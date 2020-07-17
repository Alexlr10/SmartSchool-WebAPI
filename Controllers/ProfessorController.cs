using Microsoft.AspNetCore.Mvc;
namespace SmartSchool_WebAPI.Controleers {

    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Alex");
        }
    }
}