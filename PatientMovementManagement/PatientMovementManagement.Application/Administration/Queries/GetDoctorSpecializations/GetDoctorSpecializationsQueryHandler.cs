using MediatR;
using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Queries.GetDoctorSpecializations
{
    public class GetDoctorSpecializationsQueryHandler : IRequestHandler<GetDoctorSpecializationsQuery, List<SpecializationVm>>
    {
        private readonly IPatientMoveDbContext _context;
        public GetDoctorSpecializationsQueryHandler(IPatientMoveDbContext context)
        {
            _context = context;
        }
        public async Task<List<SpecializationVm>> Handle(GetDoctorSpecializationsQuery request, CancellationToken cancellationToken)
        {
            var specializations = await _context.Employees.OrderByDescending(s => s.Specialization).Select(s => s.Specialization).ToListAsync(cancellationToken);

            var specList = new List<SpecializationVm>();

            foreach (var spec in specializations)
            {
                specList.Add(new SpecializationVm()
                {
                    SpecializationName = spec
                });
            }

            return specList;
        }
    }
}
