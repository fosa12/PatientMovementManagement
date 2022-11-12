using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetEndedVisitsByUserGuid
{
    public class EndedVisitDto
    {
        public int Id { get; set; }
        public string DoctorFullName { get; set; }
        public string Specialization { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
