using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PatientMovementManagement.Controllers
{
    [Route("api/hc")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrgins")]
    public class HealthChecksController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>>GetAsync()
        {
            return "Healthy";
        }
    }
}
