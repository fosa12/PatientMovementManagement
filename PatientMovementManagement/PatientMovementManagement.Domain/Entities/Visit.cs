using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class Visit : AuditableEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string VisitCode { get; set; }
        public string? Diagnosis { get; set; }
        public string? Recommendations { get; set; }
        public string? NextVisitRecomended { get; set; }
        public bool IsVisitTookPlace { get; set; }
    }
}
