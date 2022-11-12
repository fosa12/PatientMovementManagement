using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetEndedVisitsByUserGuid
{
    public class EndedVisitsVm
    {
        public List<EndedVisitDto> EndedVisits { get; set; }
        public int Count { get; set; }
    }
}
