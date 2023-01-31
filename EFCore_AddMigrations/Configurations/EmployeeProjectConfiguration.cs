using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_CodeFirst.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            // TABLE NAME
            builder.ToTable("EmployeeProject");

            // PRIMARY KEY
            builder.HasKey(ep => ep.EmployeeProjectId);

            // CONSTRAINTS
            builder.Property(ep => ep.Rate).HasColumnType("money");
        }
    }
}
