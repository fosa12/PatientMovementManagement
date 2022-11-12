using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class WorkPlan : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<DayInWorkPlan> DaysInWorkPlan { get; set; }
    }
}
