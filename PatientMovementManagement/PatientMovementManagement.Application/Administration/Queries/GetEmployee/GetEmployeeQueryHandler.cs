using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Queries.GetEmployee
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, EmployeeVm>
    {
        private readonly IPatientMoveDbContext _context;
        public GetEmployeeQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }
        public async Task<EmployeeVm> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employees = await _context.Employees.Where(e => e.StatusId == 1).ToListAsync(cancellationToken);

            var employeeVm = new EmployeeVm() { Employees = new List<EmployeeDto>() };

            foreach (var emp in employees)
            {
                employeeVm.Employees.Add(new EmployeeDto()
                {
                    EmployeeId = emp.Id,
                    FullName = emp.FirstName + " " + emp.LastName
                });
            }

            return employeeVm;
        }
    }
}
