using MediatR;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDates.GetAvailableVisitDay;
using PatientMovementManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetAvailableVisitsDatesByDoctorSpec.GetAvailableVisitDay
{
    public class GetAvailableVisitDayByDoctorSpecQueryHandler : IRequestHandler<GetAvailableVisitDayByDoctorSpecQuery, AvailableVisitDayVm>
    {
        private readonly IPatientMoveDbContext _context;
        public GetAvailableVisitDayByDoctorSpecQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }

        public async Task<AvailableVisitDayVm> Handle(GetAvailableVisitDayByDoctorSpecQuery request, CancellationToken cancellationToken)
        {
            var doctors = _context.Employees.Where(x => x.Specialization == request.SpecName && x.StatusId == 1).ToList();

            var availableVisitDayVm = new AvailableVisitDayVm();
            availableVisitDayVm.AvailableDayVisit = new List<AvailableVisitDayDto>();

            foreach (var doctor in doctors)
            {
                var workPlan = _context.AvailableVisits.Where(a => a.EmployeeId == doctor.Id && a.StatusId == 1).Select(row => row.VisitDateTime.Date).Distinct().ToList();//.Select(row => row.VisitDateTime.Date).Distinct().ToList();

                if (workPlan.Count != 0)
                {
                    foreach (var visit in workPlan)
                    {
                        var availableVisitDayDto = new AvailableVisitDayDto()
                        {
                            DayInMonth = visit.Day,
                            Month = visit.Month,
                            EmployeeId = doctor.Id
                        };
                        availableVisitDayVm.AvailableDayVisit.Add(availableVisitDayDto);
                    }
                }
            }


            return availableVisitDayVm;
        }
    }
}
