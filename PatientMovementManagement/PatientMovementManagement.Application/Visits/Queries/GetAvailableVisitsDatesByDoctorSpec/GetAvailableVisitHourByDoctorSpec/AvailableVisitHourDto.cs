using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitHourByDoctorSpec
{
    public class AvailableVisitHourDto
    {
        public string Hour { get; set; }
        public int AvailableVisitId { get; set; }
    }
}
