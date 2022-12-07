using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Commands.RemoveVisitReservation
{
    public class DeleteVisitReservationHandler : IRequestHandler<DeleteVisitReservationCommand>
    {
        private readonly IPatientMoveDbContext _context;
        public DeleteVisitReservationHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteVisitReservationCommand request, CancellationToken cancellationToken)
        {
            var visit = await _context.Visits.Where(v => v.Id == request.VisitId).FirstOrDefaultAsync();

            _context.Visits.Remove(visit);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
