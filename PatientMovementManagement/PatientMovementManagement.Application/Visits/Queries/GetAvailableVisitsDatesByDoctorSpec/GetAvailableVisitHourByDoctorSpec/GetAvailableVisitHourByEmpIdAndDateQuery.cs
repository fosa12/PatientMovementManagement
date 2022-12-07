using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitHourByDoctorSpec
{
    public class GetAvailableVisitHourByEmpIdAndDateQuery : IRequest<AvailableVisitHourVm>
    {
        public DateTime VisitDate { get; set; }
        public int EmployeeId { get; set; }
    }
}
