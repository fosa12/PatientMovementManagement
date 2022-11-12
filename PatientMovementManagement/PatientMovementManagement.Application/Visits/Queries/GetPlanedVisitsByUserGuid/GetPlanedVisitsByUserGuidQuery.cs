using MediatR;
using PatientMovementManagement.Application.Visits.Queries.GetVisitDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid
{
    public class GetPlanedVisitsByUserGuidQuery : IRequest<PlanedVisitsVm>
    {
        public Guid UserGuid { get; set; }
    }
}
