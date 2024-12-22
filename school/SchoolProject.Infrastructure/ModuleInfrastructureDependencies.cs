using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstractes;
using SchoolProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services )
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
