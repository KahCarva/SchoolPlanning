using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolPlanning.Infrastructure;
using SchoolPlanning.Infrastructure.Interfaces;
using SchoolPlanning.Infrastructure.Repositories;
using SchoolPlanning.Services;
using SchoolPlanning.Services.Interfaces;

namespace SchoolPlanning.IoC
{
    public static class DependencyResolver
    {

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IClassesService, ClassesService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ISchoolService, SchoolService>();
        }

        public static void RegisterInfrastructure(IServiceCollection services)
        {
            services.AddTransient<IClassesRepository, ClassesRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ISchoolRepository, SchoolRepository>();

        }

        public static void RegisterDB(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SchoolPlanningContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }


    }
}
