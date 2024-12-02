using ManagementSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagementSystem.Api.Data.Mappings;

public class PositionMapping : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.ToTable("Position");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR(100)");

        builder.HasOne(x => x.Department)
            .WithMany(x => x.Positions)
            .HasForeignKey(x => x.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);  
   
        builder.HasMany(x => x.Employees)
            .WithOne(x => x.Position)
            .HasForeignKey(x => x.PositionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
