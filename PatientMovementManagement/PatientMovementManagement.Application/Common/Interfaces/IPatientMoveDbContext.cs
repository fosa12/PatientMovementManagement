using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Application.Common.Interfaces
{
    public interface IPatientMoveDbContext
    {
        public DbSet<DayInWorkPlan> DaysInWorkPlan { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<WorkPlan> WorkPlans { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Employee> Employees { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
