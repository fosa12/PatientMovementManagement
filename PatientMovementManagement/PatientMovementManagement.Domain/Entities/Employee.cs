using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public Guid UserGuid { get; set; }
        public string Position { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Specialization { get; set; }
        public WorkPlan WorkPlan { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
