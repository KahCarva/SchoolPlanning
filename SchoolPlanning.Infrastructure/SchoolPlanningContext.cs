using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolPlanning.Domain.Entities;
using SchoolPlanning.Infrastructure.Configuration;

namespace SchoolPlanning.Infrastructure
{
    public class SchoolPlanningContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SchoolPlanningContext(DbContextOptions<SchoolPlanningContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public SchoolPlanningContext(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new SchoolEntityConfiguration().Configure(modelBuilder.Entity<School>());
            new EmployeeEntityConfiguration().Configure(modelBuilder.Entity<Employee>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
