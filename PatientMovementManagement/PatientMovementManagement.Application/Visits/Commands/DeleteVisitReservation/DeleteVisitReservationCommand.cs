using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Commands.RemoveVisitReservation
{
    public class DeleteVisitReservationCommand : IRequest
    {
        public int VisitId { get; set; }
    }
}
