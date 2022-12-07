using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDates.GetAvailableVisitDay
{
    public class AvailableVisitDayDto
    {
        public int DayInMonth { get; set; }
        public int Month { get; set; }
        public int EmployeeId { get; set; }
    }
}
