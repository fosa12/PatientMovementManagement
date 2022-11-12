using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetVisitDetail
{
    public class GetVisitDetailQueryHandler : IRequestHandler<GetVisitDetailQuery, VisitDetailVm>
    {
        private readonly IPatientMoveDbContext _context;

        public GetVisitDetailQueryHandler(IPatientMoveDbContext patientMoveDbContext)
        {
            _context = patientMoveDbContext;
        }

        public async Task<VisitDetailVm> Handle(GetVisitDetailQuery request, CancellationToken cancellationToken)
        {
            var visit = await _context.Visits.Where(p => p.Id == request.Id).Include(d => d.Employee).FirstOrDefaultAsync(cancellationToken);

            var vistVm = new VisitDetailVm()
            {
                Diagnosis = visit.Diagnosis,
                IsVisitTookPlace = visit.IsVisitTookPlace,
                NextVisitRecomended = visit.NextVisitRecomended,
                Recommendations = visit.Recommendations,
                VisitCode = visit.VisitCode,
                VisitDateTime = visit.VisitDateTime,
                DoctorFullName = visit.Employee.FirstName + " " + visit.Employee.LastName,
                Specialization = visit.Employee.Specialization
            };

            return vistVm;
        }
    }
}
