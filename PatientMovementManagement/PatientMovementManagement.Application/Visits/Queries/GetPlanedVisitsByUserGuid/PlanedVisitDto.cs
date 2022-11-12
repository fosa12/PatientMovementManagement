using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid
{
    public class PlanedVisitDto
    {
        public int Id { get; set; }
        public string DoctorFullName { get; set; }
        public string Specialization { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitCode { get; set; }
    }
}
