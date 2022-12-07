using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientMovementManagement.Application.Visits.Commands.CreateVisit;
using PatientMovementManagement.Application.Visits.Commands.RemoveVisitReservation;
using PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDates.GetAvailableVisitDay;
using PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitDay;
using PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitHourByDoctorSpec;
using PatientMovementManagement.Application.Visits.Queries.GetEndedVisitsByUserGuid;
using PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid;
using PatientMovementManagement.Application.Visits.Queries.GetVisitDetail;

namespace PatientMovementManagement.Controllers
{
    [Route("api/visits")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrgins")]
    public class VisitsController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<VisitDetailVm>> GetDetailsById(int id)
        {
            var vm = await Mediator.Send(new GetVisitDetailQuery() { Id = id });

            return vm;
        }
        [HttpGet("getplanedvisits/{userGuid}")]
        public async Task<ActionResult<PlanedVisitsVm>> GetPlanedVisitByUserGuid(Guid userGuid)
        {
            var vm = await Mediator.Send(new GetPlanedVisitsByUserGuidQuery() { UserGuid = userGuid });

            return vm;
        }
        [HttpGet("getendedvisits/{userGuid}")]
        public async Task<ActionResult<EndedVisitsVm>> GetEndedVisitByUserGuid(Guid userGuid)
        {
            var vm = await Mediator.Send(new GetEndedVisitsByUserGuidQuery() { UserGuid = userGuid });

            return vm;
        }
        [HttpGet("getpossibleDatesVisits/{specName}")]
        public async Task<ActionResult<AvailableVisitDayVm>> GetPossibleDatesVisitBySpecName(string specName)
        {
            var vm = await Mediator.Send(new GetAvailableVisitDayByDoctorSpecQuery() { SpecName = specName });
            return vm;
        }
        [HttpDelete("deleteVisitReservation/{visitId}")]
        public async Task<ActionResult> DeleteVisitReservation(int visitId) 
        {
            await Mediator.Send(new DeleteVisitReservationCommand() { VisitId = visitId });

            return Ok();
        }
        [HttpGet("getpossibleDatesVisitsByDateAndEmpId/{dateTime}/{employeeId}")]
        public async Task<ActionResult<AvailableVisitHourVm>> GetPossibleHourVisitByDate(DateTime dateTime, int employeeId)
        {
            //var vm = await Mediator.Send(new GetAvailableVisitHourByEmpIdAndDateQuery() { VisitDate = dateOnly, EmployeeId = employeeId });
            var vm = await Mediator.Send(new GetAvailableVisitHourByEmpIdAndDateQuery() { VisitDate = dateTime, EmployeeId = employeeId});
            return vm;
        }
        [HttpPost("newVisit")]
        public async Task<IActionResult> PostNewVisit(CreateVisitCommand createVisitCommand)
        {
            var result = await Mediator.Send(createVisitCommand);

            return Ok(result);
        }
    }
}
