using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid;
using PatientMovementManagement.Application.Visits.Queries.GetVisitDetail;

namespace PatientMovementManagement.Controllers
{
    [Route("api/visits")]
    [ApiController]
    public class VisitsController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<VisitDetailVm>> GetDetailsById(int id)
        {
            var vm = await Mediator.Send(new GetVisitDetailQuery() { Id = id });

            return vm;
        }
        [HttpGet("/getplanedvisits/{userGuid}")]
        public async Task<ActionResult<PlanedVisitsVm>> GetPlanedVisitByUserGuid(Guid userGuid)
        {
            var vm = await Mediator.Send(new GetPlanedVisitsByUserGuidQuery() { UserGuid = userGuid });

            return vm;
        }
        [HttpGet("/getendedvisits/{userGuid}")]
        public async Task<ActionResult<PlanedVisitsVm>> GetEndedVisitByUserGuid(Guid userGuid)
        {
            var vm = await Mediator.Send(new GetPlanedVisitsByUserGuidQuery() { UserGuid = userGuid });

            return vm;
        }
    }
}
