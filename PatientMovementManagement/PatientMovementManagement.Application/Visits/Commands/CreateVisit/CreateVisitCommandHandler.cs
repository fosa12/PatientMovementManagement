using MediatR;
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
            Visit visit = new Visit()
            {
                VisitDateTime = request.VisitDateTime,
                VisitCode = "123",
                IsVisitTookPlace = false,
            };

            _context.Visits.Add(visit);

            await _context.SaveChangesAsync(cancellationToken);

            return visit.Id;
        }
    }
}
