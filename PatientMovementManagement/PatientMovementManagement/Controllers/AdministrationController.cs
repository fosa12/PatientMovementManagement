using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientMovementManagement.Application.Administration.Commands.CreateDayInWorkPlanCommand;
using PatientMovementManagement.Application.Administration.Queries.GetDoctorSpecializations;
using PatientMovementManagement.Application.Administration.Queries.GetEmployee;

namespace PatientMovementManagement.Controllers
{
    [Route("api/administration")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrgins")]
    public class AdministrationController : BaseController
    {
        [HttpGet("specialization")]
        public async Task<ActionResult<List<SpecializationVm>>> GetDoctorSpecializations()
        {
            var vm = await Mediator.Send(new GetDoctorSpecializationsQuery());

            return vm;
        }
        [HttpGet("employees")]
        public async Task<ActionResult<EmployeeVm>> GetEmployee()
        {
            var vm = await Mediator.Send(new GetEmployeeQuery());

            return vm;
        }
        [HttpPost("newDayInWorkPlan")]
        public async Task<IActionResult> PostNewDayInWorkPlan(CreateDayInWorkPlanCommand createDayInWorkPlanCommand)
        {
            var result = await Mediator.Send(createDayInWorkPlanCommand);

            return Ok(result);
        }
    }

}
