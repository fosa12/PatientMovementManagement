using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid
{
    public class PlanedVisitsVm
    {
        public List<PlanedVisitDto> PlanedVisits { get; set; }
        public int Count { get; set; }
    }
}
