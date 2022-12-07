using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class DayInWorkPlan : AuditableEntity
    {
        public int WorkPlanId { get; set; }
        public WorkPlan WorkPlan { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public ICollection<AvailableVisit>? AvailableVisits { get; set; }
    }
}
