using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatientMovementManagement.Application.Common.Interfaces;
using PatientMovementManagement.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }
    }
}
