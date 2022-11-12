using PatientMovementManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Domain.Entities
{
    public class Patient : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public Guid UserGuid { get; set; }
        public ICollection<Visit> Visits { get; set; }

    }
}
