using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetEndedVisitsByUserGuid
{
    public class GetEndedVisitsByUserGuidQueryHandler : IRequestHandler<GetEndedVisitsByUserGuidQuery, EndedVisitsVm>
    {
        private readonly IPatientMoveDbContext _context;
        public GetEndedVisitsByUserGuidQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }
        public async Task<EndedVisitsVm> Handle(GetEndedVisitsByUserGuidQuery request, CancellationToken cancellationToken)
        {
            var patientId = await GetPatientId(request.UserGuid);

            var visits = _context.Visits.Where(v => v.PatientId == patientId && v.IsVisitTookPlace == true && v.StatusId == 1).Include(d => d.Employee);

            EndedVisitsVm endedVisits = MapEndedVisit(visits);

            return endedVisits;
        }

        private EndedVisitsVm MapEndedVisit(IQueryable<Visit> visits)
        {
            var planedVisitsVm = new EndedVisitsVm();
            planedVisitsVm.EndedVisits = new List<EndedVisitDto>();
            foreach (var visit in visits)
            {
                var endedVisit = new EndedVisitDto()
                {
                    DoctorFullName = visit.Employee.FirstName + " " + visit.Employee.LastName,
                    Id = visit.Id,
                    Specialization = visit.Employee.Specialization,
                    VisitDate = visit.VisitDateTime
                };
                planedVisitsVm.EndedVisits.Add(endedVisit);
            }
            planedVisitsVm.Count = visits.Count();
            return planedVisitsVm;
        }

        private async Task<int> GetPatientId(Guid userGuid)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.UserGuid == userGuid);

            int patientId = patient.Id;

            return patientId;
        }
    }
}
