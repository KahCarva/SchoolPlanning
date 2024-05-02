using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolPlanning.Infrastructure;
using SchoolPlanning.Infrastructure.Interfaces;
using SchoolPlanning.Infrastructure.Repositories;

namespace SchoolPlanning.IoC
{
    public static class DependencyResolver
    {

        public static void RegisterServices(IServiceCollection services)
        {

        }

        public static void RegisterInfrastructure(IServiceCollection services)
        {
            //services.AddTransient<IRepositorie, Repositorie>();
            
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
