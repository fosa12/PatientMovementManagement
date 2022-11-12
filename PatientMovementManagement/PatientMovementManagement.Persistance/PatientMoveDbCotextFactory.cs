using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Persistance
{
    public class PatientMoveDbCotextFactory : DesignTimeDbContextFactoryBase<PatientMovementDbContext>
    {
        protected override PatientMovementDbContext CreateNewInstance(DbContextOptions<PatientMovementDbContext> options)
        {
            return new PatientMovementDbContext(options);
        }
    }
}
