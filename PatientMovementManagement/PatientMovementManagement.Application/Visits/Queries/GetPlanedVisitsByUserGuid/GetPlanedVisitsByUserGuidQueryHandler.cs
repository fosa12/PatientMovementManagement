using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetPlanedVisitsByUserGuid
{
    public class GetPlanedVisitsByUserGuidQueryHandler : IRequestHandler<GetPlanedVisitsByUserGuidQuery, PlanedVisitsVm>
    {
        private readonly IPatientMoveDbContext _context;
        public GetPlanedVisitsByUserGuidQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }

        public async Task<PlanedVisitsVm> Handle(GetPlanedVisitsByUserGuidQuery request, CancellationToken cancellationToken)
        {
            var patientId = await GetPatientId(request.UserGuid);

            var visits =  _context.Visits.Where(v => v.PatientId == patientId && v.IsVisitTookPlace == false && v.StatusId == 1).Include(d => d.Employee);

            PlanedVisitsVm planedVisitsVm = MapPlanedVisits(visits);

            return planedVisitsVm;
        }

        private PlanedVisitsVm MapPlanedVisits(IQueryable<Visit> visits)
        {
            var planedVisitsVm = new PlanedVisitsVm();
            planedVisitsVm.PlanedVisits = new List<PlanedVisitDto>();

            foreach (var visit in visits)
            {
                var planedVisit = new PlanedVisitDto()
                {
                    DoctorFullName = visit.Employee.FirstName + " " + visit.Employee.LastName,
                    Id = visit.Id,
                    Specialization = visit.Employee.Specialization,
                    VisitCode = visit.VisitCode,
                    VisitDate = visit.VisitDateTime
                };
                planedVisitsVm.PlanedVisits.Add(planedVisit);
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
