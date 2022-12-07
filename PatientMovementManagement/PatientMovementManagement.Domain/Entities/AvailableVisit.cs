using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class AvailableVisit : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string VisitCode { get; set; }
        public int? DayInWorkPlanId { get; set; }
        public DayInWorkPlan? DayInWorkPlan { get; set; }
    }
}
