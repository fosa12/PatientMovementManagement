using MediatR;
using PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDates.GetAvailableVisitDay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitDay
{
    public class GetAvailableVisitDayByDoctorSpecQuery : IRequest<AvailableVisitDayVm>
    {
        public string SpecName { get; set; }
    }
}
