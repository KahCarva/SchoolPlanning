using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolPlanning.Domain.Entities;

namespace SchoolPlanning.Infrastructure.Configuration
{
    public class SchoolEntityConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            
        }
    }
}
