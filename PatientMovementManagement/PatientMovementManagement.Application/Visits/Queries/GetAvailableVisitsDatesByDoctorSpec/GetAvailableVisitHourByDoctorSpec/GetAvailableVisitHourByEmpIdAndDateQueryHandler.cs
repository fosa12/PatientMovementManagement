using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitHourByDoctorSpec
{
    public class GetAvailableVisitHourByEmpIdAndDateQueryHandler : IRequestHandler<GetAvailableVisitHourByEmpIdAndDateQuery, AvailableVisitHourVm>
    {
        private readonly IPatientMoveDbContext _context;
        public GetAvailableVisitHourByEmpIdAndDateQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }

        public async Task<AvailableVisitHourVm> Handle(GetAvailableVisitHourByEmpIdAndDateQuery request, CancellationToken cancellationToken)
        {
            var availableVisits = await _context.AvailableVisits.Where(a => a.EmployeeId == request.EmployeeId && 
            a.StatusId == 1 &&
            a.VisitDateTime.Day == request.VisitDate.Day &&
            a.VisitDateTime.Month == request.VisitDate.Month &&
            a.VisitDateTime.Year == request.VisitDate.Year)
                .ToListAsync(cancellationToken);

            var availableVisitHourVm = new AvailableVisitHourVm() { AvailableVisitsHour = new List<AvailableVisitHourDto>() };

            foreach (var avaVisits in availableVisits)
            {
                availableVisitHourVm.AvailableVisitsHour.Add(new AvailableVisitHourDto()
                {
                    AvailableVisitId = avaVisits.Id,
                    Hour = CreateHourString(avaVisits.VisitDateTime)
                });
            }
            return availableVisitHourVm;
        }
        private string CreateHourString(DateTime dateTime)
        {
            if(dateTime.Minute < 10)
            {
                return dateTime.Hour.ToString() + ":" + "0" +dateTime.Minute.ToString();
            }
            else
            {
                return dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
            }
        }
    }
}
