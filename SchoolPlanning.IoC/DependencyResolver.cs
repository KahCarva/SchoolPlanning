using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolPlanning.Infrastructure;

namespace SchoolPlanning.IoC
{
    public static class DependencyResolver
    {

        public static void RegisterServices(IServiceCollection serviceCollection)
        {

        }

        public static void RegisterInfrastructure(IServiceCollection serviceCollection)
        {

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
