using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Commands.CreateVisit
{
    public class CreateVisitVm
    {
        public int UserId { get; set; }
        public int AvailableVisitId { get; set; }
    }
}
