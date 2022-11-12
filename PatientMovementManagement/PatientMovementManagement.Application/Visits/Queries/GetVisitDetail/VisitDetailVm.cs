using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetVisitDetail
{
    public class VisitDetailVm
    {
        public Guid UserId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string DoctorFullName { get; set; }
        public string Specialization { get; set; }
        public string VisitCode { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendations { get; set; }
        public string NextVisitRecomended { get; set; }
        public bool IsVisitTookPlace { get; set; }
    }
}
