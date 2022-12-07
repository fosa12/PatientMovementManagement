using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Commands.CreateDayInWorkPlanCommand
{
    public class CreateDayInWorkPlanCommandHandler : IRequestHandler<CreateDayInWorkPlanCommand, int>
    {
        private readonly IPatientMoveDbContext _context;
        public CreateDayInWorkPlanCommandHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateDayInWorkPlanCommand request, CancellationToken cancellationToken)
        {
            var workPlan = await _context.WorkPlans.Where(w => w.EmployeeId == request.CreateDayInWorkPlan.EmployeeId).FirstOrDefaultAsync();

            var newDayInWorkPlan = new DayInWorkPlan();

            if (workPlan == null)
            {
                var newWorkPlan = new WorkPlan()
                {
                    EmployeeId = request.CreateDayInWorkPlan.EmployeeId,
                    StatusId = 1,
                };
                 _context.WorkPlans.Add(newWorkPlan);
                await _context.SaveChangesAsync();

                newDayInWorkPlan.WorkStart = request.CreateDayInWorkPlan.WorkStart;
                newDayInWorkPlan.WorkEnd = request.CreateDayInWorkPlan.WorkEnd;
                newDayInWorkPlan.WorkPlanId = newWorkPlan.Id;

                _context.DaysInWorkPlan.Add(newDayInWorkPlan);

                await _context.SaveChangesAsync();

                await CreateAvailableVisit(newDayInWorkPlan, request.CreateDayInWorkPlan.EmployeeId, cancellationToken);

            }
            else
            {

                newDayInWorkPlan.WorkStart = request.CreateDayInWorkPlan.WorkStart;
                newDayInWorkPlan.WorkEnd = request.CreateDayInWorkPlan.WorkEnd;
                newDayInWorkPlan.WorkPlanId = workPlan.Id;

                _context.DaysInWorkPlan.Add(newDayInWorkPlan);

                await _context.SaveChangesAsync();

                await CreateAvailableVisit(newDayInWorkPlan, request.CreateDayInWorkPlan.EmployeeId, cancellationToken);
            }



            return newDayInWorkPlan.Id;
        }

        private async Task<Unit> CreateAvailableVisit(DayInWorkPlan dayInWorkPlan, int employeeId, CancellationToken cancellationToken)
        {
            var workStartDateTime = dayInWorkPlan.WorkStart;

            var empl = await _context.Employees.FirstOrDefaultAsync(e => e.Id == employeeId);

            int nextNumber = 0;

            while (workStartDateTime < dayInWorkPlan.WorkEnd)
            {
                nextNumber++;

                workStartDateTime = workStartDateTime.AddMinutes(15);


                var availableVisit = new AvailableVisit()
                {
                    EmployeeId = employeeId,
                    VisitDateTime = workStartDateTime,
                    VisitCode = nextNumber.ToString() + workStartDateTime.Day.ToString() + "-" + empl.Specialization.Substring(0, 2).ToUpper(),
                    StatusId = 1,
                };

                _context.AvailableVisits.Add(availableVisit);
            }
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
