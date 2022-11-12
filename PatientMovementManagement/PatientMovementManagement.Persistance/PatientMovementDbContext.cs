using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Domain.Common;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Persistance
{
    public class PatientMovementDbContext : DbContext, IPatientMoveDbContext
    {
        private readonly IDateTime _dateTime;
        public PatientMovementDbContext(DbContextOptions<PatientMovementDbContext> options) : base(options)
        {

        }
        public PatientMovementDbContext(DbContextOptions<PatientMovementDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }
        public DbSet<DayInWorkPlan> DaysInWorkPlan { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<WorkPlan> WorkPlans { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.SeedData();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
    
}
