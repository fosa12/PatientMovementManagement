using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Commands.CreateVisit
{
    public class CreateVisitCommand : IRequest<int>
    {
        public Guid UserId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime VisitDateTime { get; set; }
    }
}
