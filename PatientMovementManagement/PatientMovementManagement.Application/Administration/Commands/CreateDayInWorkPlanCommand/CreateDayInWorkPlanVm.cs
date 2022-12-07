using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Administration.Commands.CreateDayInWorkPlanCommand
{
    public class CreateDayInWorkPlanVm
    {
        public int EmployeeId { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
    }
}
