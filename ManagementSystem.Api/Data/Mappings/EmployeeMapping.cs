using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Api.Data.Mappings;

public class EmployeeMapping : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("NVARCHAR(50)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("NVARCHAR(80)");

        builder.Property(x => x.Email)
            .IsRequired() 
            .HasColumnType("NVARCHAR(180)");

        builder.Property(x => x.PhoneNumber)
            .IsRequired() 
            .HasColumnType("NVARCHAR(20)");

        builder.Property(x => x.Cpf)
            .IsRequired() 
            .HasColumnType("NVARCHAR(11)");

        builder.Property(x => x.Salary)
            .HasColumnType("DECIMAL(18,2)");

        builder.Property(x => x.Status)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(x => x.HiredAt)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.Property(x => x.UpdatedAt)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.Property(x => x.ActivatedAt)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.Property(x => x.ResignedAt)
            .IsRequired(false)
            .HasColumnType("DATETIME");

        builder.HasIndex(x => x.Cpf)
            .IsUnique()
            .HasDatabaseName("IX_Employee_Cpf");

        builder.HasIndex(x => x.Email)
            .IsUnique()
            .HasDatabaseName("IX_Employee_Email");

        builder.HasOne(x => x.Department)
            .WithMany(x => x.Employees) 
            .HasForeignKey(x => x.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Position)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.PositionId) 
            .OnDelete(DeleteBehavior.Cascade); 
    }
}
