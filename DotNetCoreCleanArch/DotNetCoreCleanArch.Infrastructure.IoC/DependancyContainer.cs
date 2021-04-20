using DotNetCoreCleanArch.Application.Interfaces;
using DotNetCoreCleanArch.Application.Services;
using DotNetCoreCleanArch.Domain.Interfaces;
using DotNetCoreCleanArch.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCleanArch.Infrastructure.IoC
{
   public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }

    }
}
