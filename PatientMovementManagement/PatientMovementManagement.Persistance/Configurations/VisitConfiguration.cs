using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Persistance.Configurations
{
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {

            builder.Property(x => x.VisitDateTime).IsRequired();

            builder.Property(x => x.VisitCode).IsRequired();

            builder.Property(x => x.IsVisitTookPlace).IsRequired().HasDefaultValue(false);
        }
    }
}
