using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Commands.CreateVisit
{
    public class CreateVisitCommandHandler : IRequestHandler<CreateVisitCommand, int>
    {
        private readonly IPatientMoveDbContext _context;

        public CreateVisitCommandHandler(IPatientMoveDbContext patientMoveDbContext)
        {
            _context = patientMoveDbContext;
        }

        public async Task<int> Handle(CreateVisitCommand request, CancellationToken cancellationToken)
        {
            var availableVisit = await _context.AvailableVisits.Where(a => a.Id == request.VisitToCreate.AvailableVisitId).FirstOrDefaultAsync();

            Visit visit = new Visit()
            {
                EmployeeId = availableVisit.EmployeeId,
                PatientId = request.VisitToCreate.UserId,
                StatusId = 1,
                VisitCode = availableVisit.VisitCode,
                VisitDateTime = availableVisit.VisitDateTime,
                IsVisitTookPlace = false
            };

            _context.AvailableVisits.Remove(availableVisit);
            _context.Visits.Add(visit);
            await _context.SaveChangesAsync(cancellationToken);

            return visit.Id;
        }
    }
}
