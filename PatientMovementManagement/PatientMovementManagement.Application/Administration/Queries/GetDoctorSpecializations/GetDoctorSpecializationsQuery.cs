using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Queries.GetDoctorSpecializations
{
    public class GetDoctorSpecializationsQuery : IRequest<List<SpecializationVm>>
    {
    }
}
