using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolPlanning.Domain.Entities;

namespace SchoolPlanning.Infrastructure.Configuration
{
    public class ClassesEntityConfiguration : IEntityTypeConfiguration<Classes>
    {
        public void Configure(EntityTypeBuilder<Classes> builder)
        {
            //builder.HasOne(q => q.Employee).WithOne(q => q.Classes);
        }
    }
}
