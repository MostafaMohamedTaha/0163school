using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstractes;
using SchoolProject.Services.Abstracts;
using SchoolProject.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Services
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services) {
            services.AddTransient<IStudentService,StudentService>();
            return services;
        }

    }
}
