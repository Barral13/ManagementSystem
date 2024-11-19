using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Api.Data.Mappings;

public class DepartmentMapping : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Department");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR(100)");

        builder.HasMany(x => x.Positions)
            .WithOne(x => x.Department)
            .HasForeignKey(x => x.DepartmentId) 
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Employees)
            .WithOne(x => x.Department) 
            .HasForeignKey(x => x.DepartmentId)  
            .OnDelete(DeleteBehavior.Cascade);  
    }
}
