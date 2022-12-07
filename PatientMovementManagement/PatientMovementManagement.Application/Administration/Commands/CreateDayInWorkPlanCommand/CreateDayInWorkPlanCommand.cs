using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Commands.CreateDayInWorkPlanCommand
{
    public class CreateDayInWorkPlanCommand : IRequest<int>
    {
        public CreateDayInWorkPlanVm CreateDayInWorkPlan { get; set; }
    }
}
