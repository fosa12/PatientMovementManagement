using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Visits.Queries.GetVisitDetail
{
    public class GetVisitDetailQuery : IRequest<VisitDetailVm>
    {
        public int Id { get; set; }
    }
}
