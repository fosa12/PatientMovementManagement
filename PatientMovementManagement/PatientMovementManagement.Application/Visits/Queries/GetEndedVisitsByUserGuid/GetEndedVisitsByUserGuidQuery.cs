using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetEndedVisitsByUserGuid
{
    public class GetEndedVisitsByUserGuidQuery : IRequest<EndedVisitsVm>
    {
        public Guid UserGuid { get; set; }
    }
}
